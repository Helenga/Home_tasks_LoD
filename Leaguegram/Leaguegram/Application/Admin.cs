using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Application
{
    internal class Admin : User, IAdmin
    {
        public void DeleteUser(string username)
        {
            throw new NotImplementedException();
        }

        public void InviteUser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
