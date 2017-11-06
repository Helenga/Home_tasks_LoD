using System;

using EnglishTrainer.Domain;

namespace EnglishTrainer.Infrastructure
{
    interface IUserRepository
    {
        Guid FindUserByName(string name);

        void SaveNewUser(User newUser);
    }
}
