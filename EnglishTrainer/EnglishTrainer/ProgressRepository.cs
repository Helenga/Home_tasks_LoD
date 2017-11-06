using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnglishTrainer.Infrastructure
{
    class ProgressRepository : IProgressRepository
    {
        public ProgressRepository(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<T> GetProgressForUser<T>(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProgressForUser<T>(Guid userId, T words)
        {
            /*var serializedId = JsonConvert.SerializeObject(userId);
            var serializedWords = JsonConvert.SerializeObject(words);
            var serialized = serializedId + serializedWords;
            File.WriteAllText(_filePath, serialized);*/
        }

        private string _filePath;
    }
}
