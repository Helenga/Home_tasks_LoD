using System;

namespace EnglishTrainer.Application
{
    interface IUserService
    {
        Guid Registrate(string name);

        Guid Login(string name);
    }
}
