using System.Collections.Generic;
using System;

namespace EnglishTrainer.Domain
{
    [Serializable]
    internal class WordOnLearning : IWordOnLearning
    {
        public WordOnLearning(KeyValuePair<string, string> wordToLearn)
        {
            Combination = wordToLearn;
            _counter = 0;
        }

        public void IncreaseCounter()
        {
            _counter++;
        }

        public bool NumberOfIterationsIsEnoughToConsiderWordIsLearned()
        {
            return _counter == 3;
        }

        public KeyValuePair<string, string> Combination { get; }
        private byte _counter;
    }
}
