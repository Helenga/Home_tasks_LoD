using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Application
{
    internal class Admin : User, IAdmin
    {
        public void DeleteUser(string username, Guid chatId)
        {
            Guid userId = ChooseUser(username);
            _chatsRepository.DeleteUserFromChat(_account.Id, chatId, userId);
        }

        public void InviteUser(string username, Guid chatId)
        {
            Guid userId = ChooseUser(username);
            _chatsRepository.AddUserToChat(_account.Id, chatId, userId);
        }
    }
}
