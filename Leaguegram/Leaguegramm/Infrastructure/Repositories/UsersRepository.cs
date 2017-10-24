using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegramm.Application;

namespace Leaguegramm.Infrastructure.Repositories
{
    class UsersRepository
    {
        static UsersRepository()
        {
            usersRepository = new List<User>();
        }

        static List<User> usersRepository;

        
    }
}
