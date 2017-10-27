using System;

namespace Leaguegram.Application
{
    interface IAuthor : IAdmin
    {/*
        void AuthorizeUser(Guid userId, Guid chatId);
        void DemoteUser(Guid userId, Guid chatId);
        */
        void ChangeUserStatus(Guid userId, Guid chatId);
    }
}
