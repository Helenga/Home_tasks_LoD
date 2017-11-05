using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Domain
{
    interface IDictionary
    {
        KeyValuePair<string, string> GetRandomPairOfWordAndItsTranslation();

        string GetRandomTranslation();

        bool WordsEnded();
    }
}
