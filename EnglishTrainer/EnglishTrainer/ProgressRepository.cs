using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace EnglishTrainer.Infrastructure
{
    class ProgressRepository : IProgressRepository
    {
        public ProgressRepository(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<dynamic> GetProgressForUser(Guid userId)
        {
            var progress = LoadProgress();
            if (progress.ContainsKey(userId))
                return progress[userId];
            else
                return new List<dynamic>();
                
        }

        public void UpdateProgressForUser<T>(Guid userId, T words)
        {
            Dictionary<Guid, T> progress = new Dictionary<Guid, T>();
            progress.Add(userId, words);
            var serialzed = JsonConvert.SerializeObject(progress);
            File.WriteAllText(_filePath, serialzed);
        }

        private Dictionary<Guid, dynamic> LoadProgress()
        {
            try
            {
                var raws = File.ReadAllText(_filePath);
                if (raws == "")
                    return new Dictionary<Guid, dynamic>();
                var progress = JsonConvert.DeserializeObject<Dictionary<Guid, dynamic>>(raws);
                return progress;
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

        private string _filePath;
    }
}
