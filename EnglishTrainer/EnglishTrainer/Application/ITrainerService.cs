using System;
using System.Collections.Generic;

namespace EnglishTrainer.Application
{
    interface ITrainerService
    {
        IEnumerable<KeyValuePair<string, string>> StartTraining();

        void ChooseDictionaryForLearning(string dictionaryName);

        void SaveProgress(Guid userId);
    }
}
