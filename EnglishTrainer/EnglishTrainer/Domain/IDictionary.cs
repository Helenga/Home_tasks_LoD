using System.Collections.Generic;

namespace EnglishTrainer.Domain
{
    interface IDictionary
    {
        KeyValuePair<string, string> GetRandomPairOfWordAndItsTranslation();

        string GetRandomTranslation();

        bool WordsEnded();
    }
}
