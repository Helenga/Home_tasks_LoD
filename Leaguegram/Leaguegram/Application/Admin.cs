using System;

using Leaguegram.Infrastucture;
using Leaguegram.Domain;

namespace Leaguegram.Application
{
    class Admin : User, IAdmin
    {
        public Admin(
            UsersRepository usersRepository,
            Account account,
            Dialogue dialogue,
            Group group,
            Channel channel,
            ChatsRepository chatsRepository) : base(
                usersRepository,
                account,
                dialogue,
                group,
                channel,
                chatsRepository)
        { }

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
