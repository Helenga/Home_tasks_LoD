using System;
using System.Collections.Generic;

namespace EnglishTrainer.Infrastructure
{
    interface IProgressRepository
    {
        void UpdateProgressForUser<T>(Guid userId, T words);

        IEnumerable<T> GetProgressForUser<T>(Guid userId);
    }
}
