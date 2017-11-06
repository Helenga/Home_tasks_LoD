using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Infrastructure
{
    class DictionaryRepository : IDictionaryRepository
    {
        public Dictionary<string, string> ChooseDictionary(Guid dictionaryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetExistingDictionaries()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> LoadNewDictionary<T>(T dictionaryPath)
        {
            throw new NotImplementedException();
        }
    }
}
