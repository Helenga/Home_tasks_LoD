using System;
using System.Collections.Generic;

namespace EnglishTrainer.Application
{
    interface ITrainerService
    {
        IEnumerable<KeyValuePair<string, string>> StartTraining();

        void ChooseDictionaryForLearning(Guid dictionaryId);

        void SaveProgress(Guid userId);
    }
}
