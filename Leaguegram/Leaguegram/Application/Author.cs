using System;

using Leaguegram.Infrastucture;
using Leaguegram.Domain;

namespace Leaguegram.Application
{
    class Author : Admin, IAuthor
    {
        public Author(
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
        {}

            public void ChangeUserStatus(Guid userId, Guid chatId)
        {
            _chatsRepository.ChangeParticipantStatus(_account.Id, userId, chatId);
        }
    }
}
