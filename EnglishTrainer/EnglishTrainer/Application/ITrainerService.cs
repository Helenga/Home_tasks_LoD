using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Application
{
    interface ITrainerService
    {
        IEnumerable<KeyValuePair<string, string>> StartTraining();

        void ChooseDictionaryForLearning(Guid dictionaryId);

        void SaveProgress(Guid userId);
    }
}
