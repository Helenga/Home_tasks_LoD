using System;
using System.Collections.Generic;

namespace EnglishTrainer.Infrastructure
{
    interface IProgressRepository
    {
        void UpdateProgressForUser<T>(Guid userId, T words);

        IEnumerable<dynamic> GetProgressForUser(Guid userId);
    }
}
