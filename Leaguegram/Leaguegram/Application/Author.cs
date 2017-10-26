using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Application
{
    internal class Author : Admin, IAuthor
    {
        public void ChangeUserStatus(Guid userId, Guid chatId)
        {
            _chatsRepository.ChangeParticipantStatus(_account.Id, userId, chatId);
        }
    }
}
