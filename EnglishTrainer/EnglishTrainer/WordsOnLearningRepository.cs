using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Infrastructure
{
    internal class WordsOnLearningRepository : ProgressRepository, IProgressRepository
    {
        public WordsOnLearningRepository(string filePath) : base(filePath) { }
    }
}
