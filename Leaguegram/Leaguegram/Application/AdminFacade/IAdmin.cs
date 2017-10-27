using System;

namespace Leaguegram.Application
{
    interface IAdmin : IUser
    {
        void InviteUser(string username, Guid chatId);
        void DeleteUser(string username, Guid chatId);
    }
}
