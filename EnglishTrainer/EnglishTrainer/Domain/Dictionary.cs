using System;
using System.Collections.Generic;
using System.Linq;

namespace EnglishTrainer.Domain
{
    internal class Dictionary : IDictionary
    {
        public Dictionary(IDictionary<string, string> words)
        {
            _words = (Dictionary<string, string>)words;
        }

        public KeyValuePair<string, string> GetRandomPairOfWordAndItsTranslation()
        {
            var position = GetRandomPosition();
            return _words.ElementAt(position);
        }

        public string GetRandomTranslation()
        {
            var position = GetRandomPosition();
            return _words.ElementAt(position).Value;
        }

        public bool WordsEnded()
        {
            return !_words.Any();
        }

        public void DeleteLearnedWord(string word)
        {
            _words.Remove(word);
        }

        private int GetRandomPosition()
        {
            Random rnd = new Random();
            return rnd.Next(_words.Count);
        }

        private Dictionary<string, string> _words;
    }
}
