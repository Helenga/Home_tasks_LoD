using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Application
{
    interface IAdmin : IUser
    {
        void InviteUser(string username, Guid chatId);
        void DeleteUser(string username, Guid chatId);
    }
}
