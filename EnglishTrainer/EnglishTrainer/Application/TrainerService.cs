using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EnglishTrainer.Domain;
using EnglishTrainer.Infrastructure;

namespace EnglishTrainer.Application
{
    class TrainerService : ITrainerService
    {
        public TrainerService(IDictionaryRepository dictionaryRepository,
                             IProgressRepository progressRepository,
                             IWordsHandler wordsHandler)
        {
            _dictionaryRepository = dictionaryRepository;
            _learnedWordsRepository = progressRepository;
            _wordsOnLearningRepository = progressRepository;
            _wordsHandler = wordsHandler;
        }

        public void ChooseDictionaryForLearning(Guid dictionaryId)
        {
            var selectedDictionary = _dictionaryRepository.ChooseDictionary(dictionaryId);
            _dictionary = new Dictionary(selectedDictionary);
        }

        public void SaveProgress(Guid userId)
        {
            _learnedWordsRepository.UpdateProgressForUser(userId);
            _wordsOnLearningRepository.UpdateProgressForUser(userId);
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
                    var answer = GetAnswer();
                    if (AnswerIsRight(answer, combination))
                    {
                        _wordsHandler.UpdateStatusOfWord(combination.Key);
                    }
                }
            }
        }

        // ОТКУДА ПОЛУЧАТЬ ОТВЕТ (ОБРАБОТЧИК СОБЫТИЙ)
        private bool GetAnswer()
        {
            return default(bool);
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
        private readonly IProgressRepository _learnedWordsRepository;
        private readonly IProgressRepository _wordsOnLearningRepository;
    }
}
