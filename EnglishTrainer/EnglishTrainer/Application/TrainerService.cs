using System;
using System.Collections.Generic;

using EnglishTrainer.Domain;
using EnglishTrainer.Infrastructure;

namespace EnglishTrainer.Application
{
    internal class TrainerService : ITrainerService
    {
        public TrainerService(IDictionaryRepository dictionaryRepository,
                             ILearnedWordsRepository learnedWordsRepository,
                             IWordsOnLearningRepository wordsOnLearningRepository, 
                             IWordsHandler wordsHandler,
                             IUserActionsHandler userActionsHandler)
        {
            _dictionaryRepository = dictionaryRepository;
            _learnedWordsRepository = learnedWordsRepository;
            _wordsOnLearningRepository = wordsOnLearningRepository;
            _wordsHandler = wordsHandler;
            _userActionsHandler = userActionsHandler;
        }

        public void ChooseDictionaryForLearning(Guid dictionaryId)
        {
            var selectedDictionary = _dictionaryRepository.ChooseDictionary(dictionaryId);
            _dictionary = new Dictionary(selectedDictionary);
        }

        public void SaveProgress(Guid userId)
        {
            var wordsOnLearning = _wordsHandler.GetWordsOnLearning();
            var learnedWords = _wordsHandler.GetLearnedWords();
            _learnedWordsRepository.UpdateProgressForUser(userId, learnedWords);
            _wordsOnLearningRepository.UpdateProgressForUser(userId, wordsOnLearning);
        }

        public IEnumerable<KeyValuePair<string, string>> StartTraining()
        {
            while(!_dictionary.WordsEnded())
            {
                var combination = GenerateCombination();
                if (_wordsHandler.WordIsLearned(combination.Key))
                    _dictionary.DeleteLearnedWord(combination.Key); 
                else
                {
                    yield return combination;
                    var answer = _userActionsHandler.GetAnswer();
                    if (AnswerIsRight(answer, combination))
                    {
                        _wordsHandler.UpdateStatusOfWord(combination.Key);
                    }
                }
            }
        }

        private KeyValuePair<string, string> GenerateCombination()
        {
            var pairOfWordAndItsTranslation = _dictionary.
                                GetRandomPairOfWordAndItsTranslation();
            _wordsHandler.AddNewCombinationToLearn(pairOfWordAndItsTranslation);
            var randomTranslation = _dictionary.GetRandomTranslation();
            var combination = new KeyValuePair<string, string>(pairOfWordAndItsTranslation.Key, 
                                                               randomTranslation);
            return combination;
        }

        private bool WordTranslationEqualsToRandomTranslation(
                                    KeyValuePair<string, string> combination)
        {
            var actualTranslation = _wordsHandler.FindTranslationOfWord(combination.Key);
            return actualTranslation.Equals(combination.Value);
        }

        private bool AnswerIsRight(bool answer, KeyValuePair<string, string> combination)
        {
            return WordTranslationEqualsToRandomTranslation(combination) == answer;
        }

        private Dictionary _dictionary;
        private readonly IWordsHandler _wordsHandler;
        private readonly IDictionaryRepository _dictionaryRepository;
        private readonly ILearnedWordsRepository _learnedWordsRepository;
        private readonly IWordsOnLearningRepository _wordsOnLearningRepository;
        private readonly IUserActionsHandler _userActionsHandler;
    }
}
