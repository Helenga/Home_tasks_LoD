using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EnglishTrainer.Domain;

namespace EnglishTrainer.Infrastructure
{
    interface IUserRepository
    {
        Guid FindUserByName(string name);

        void SaveNewUser(User newUser);
    }
}
