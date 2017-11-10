using System;
using System.Collections.Generic;
using System.IO;

namespace EnglishTrainer.Infrastructure
{
    internal class DictionaryRepository : IDictionaryRepository
    {
        public DictionaryRepository(string folderPath)
        {
            _folderPath = folderPath;
        }

        public Dictionary<string, string> ChooseDictionary(string dictionaryName)
        {
            var dictionaryPath = _folderPath + "/" + dictionaryName + ".txt";
            if (File.Exists(dictionaryPath))
                return FormDictionary(dictionaryPath);
            else
                throw new FileNotFoundException("File not found");
        }

        public IEnumerable<string> GetExistingDictionaries()
        {
            if (Directory.Exists(_folderPath))
            {
                var files = Directory.GetFileSystemEntries(_folderPath, "*.txt");
                foreach (var file in files)
                    yield return Path.GetFileNameWithoutExtension(file);
            }
            else
                throw new DirectoryNotFoundException("Directory does not exist");
        }

        public Dictionary<string, string> LoadNewDictionary<T>(T dictionaryPath)
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, string> FormDictionary(string dictionaryPath)
        {
            var raws = File.ReadLines(dictionaryPath);
            var dictionary = new Dictionary<string, string>();
            foreach (var raw in raws)
            {
                var combination = raw.Split(' ');
                dictionary.Add(combination[0], combination[1]);
            }
            return dictionary;
        }

        private readonly string _folderPath;
    }
}
