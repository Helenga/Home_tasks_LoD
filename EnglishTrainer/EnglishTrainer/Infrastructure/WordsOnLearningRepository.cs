﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Infrastructure
{
    internal class WordsOnLearningRepository : IProgressRepository
    {
        public IEnumerable<T> GetProgressForUser<T>(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProgressForUser(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
