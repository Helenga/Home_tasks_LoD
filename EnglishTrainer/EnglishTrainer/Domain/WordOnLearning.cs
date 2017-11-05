using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Domain
{
    class WordOnLearning : IWordOnLearning
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
