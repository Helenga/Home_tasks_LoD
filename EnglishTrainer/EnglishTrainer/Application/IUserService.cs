using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTrainer.Application
{
    interface IUserService
    {
        Guid Registrate(string name);

        Guid Login(string name);
    }
}
