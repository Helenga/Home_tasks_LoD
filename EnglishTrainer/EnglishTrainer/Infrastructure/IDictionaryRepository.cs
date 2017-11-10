using System;
using System.Collections.Generic;

namespace EnglishTrainer.Infrastructure
{
    interface IDictionaryRepository
    {
        Dictionary<string, string> LoadNewDictionary<T>(T dictionaryPath);

        Dictionary<string, string> ChooseDictionary(string dictionaryName);

        IEnumerable<string> GetExistingDictionaries();
    }
}
