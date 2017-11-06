using System.Collections.Generic;

namespace EnglishTrainer.Domain
{
    internal class WordsHandler : IWordsHandler
    {
        public WordsHandler()
        {
            _wordsOnLearning = new List<WordOnLearning>();
            _learnedWords = new Dictionary<string, string>();
        }

        public void AddNewCombinationToLearn(KeyValuePair<string, string> combination)
        {
            var wordToLearn = new WordOnLearning(combination);
            _wordsOnLearning.Add(wordToLearn);
        }

        public void UpdateStatusOfWord(string word)
        {
            var learningWord = FindWordInWordsOnLearning(word);
            learningWord.IncreaseCounter();
            if (learningWord.NumberOfIterationsIsEnoughToConsiderWordIsLearned())
                ChangeStatusOfWordFromLearningToLearned(learningWord);
        }

        public string FindTranslationOfWord(string word)
        {
            return FindWordInWordsOnLearning(word).Combination.Value;
        }

        public IDictionary<string, string> GetLearnedWords()
        {
            return _learnedWords;
        }

        public IEnumerable<WordOnLearning> GetWordsOnLearning()
        {
            return _wordsOnLearning;
        }

        public bool WordIsLearned(string word)
        {
            return _learnedWords.ContainsKey(word);
        }

        private void ChangeStatusOfWordFromLearningToLearned(WordOnLearning learningWord)
        {
            _learnedWords.Add(learningWord.Combination.Key,
                              learningWord.Combination.Value);
            _wordsOnLearning.Remove(learningWord);
        }

        private WordOnLearning FindWordInWordsOnLearning(string word)
        {
            return _wordsOnLearning.Find(wordOnLearning => wordOnLearning.
                                         Combination.Key.Equals(word));
        }

        private readonly List<WordOnLearning> _wordsOnLearning;
        private readonly Dictionary<string, string> _learnedWords;
    }
}
