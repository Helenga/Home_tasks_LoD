using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Infrastructure
{
    class LearnedWordsRepository : ProgressRepository, IProgressRepository
    {
       public LearnedWordsRepository(string filePath) : base(filePath) { }
    }
}
