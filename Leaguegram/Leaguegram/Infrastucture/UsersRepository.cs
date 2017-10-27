using System;
using System.Collections.Generic;

using Leaguegram.Domain;
using Leaguegram.Exceptions;

namespace Leaguegram.Infrastucture
{
    internal class UsersRepository
    {
        static UsersRepository()
        {
            _accounts = new List<Account>();
        }

        public IEnumerable<Account> FindAccountsByStringForSearch(string stringForSearch)
        {
            List<Account> foundAccounts = new List<Account>();
            foreach (Account account in _accounts)
            {
                if (account.Username.Contains(stringForSearch))
                    foundAccounts.Add(account);
            }
            if (foundAccounts.Count > 0)
                return foundAccounts;
            else
                return null;
        }

        public Guid FindUserIdByName(string username)
        {
            foreach (var account in _accounts)
            {
                if (account.Username.Equals(username))
                    return account.Id;
            }
            throw new UserIsNotFoundException();
        }

        public void AddToRepository(Account account)
        {
            _accounts.Add(account);
        }

        private static List<Account> _accounts;
    }
}
