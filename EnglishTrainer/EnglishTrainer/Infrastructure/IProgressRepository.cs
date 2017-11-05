using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EnglishTrainer.Domain;

namespace EnglishTrainer.Infrastructure
{
    interface IProgressRepository
    {
        void UpdateProgressForUser(Guid userId);

        IEnumerable<T> GetProgressForUser<T>(Guid userId);
    }
}
