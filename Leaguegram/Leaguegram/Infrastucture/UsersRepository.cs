using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegram.Domain;

namespace Leaguegram.Infrastucture
{
    internal class UsersRepository
    {
        private List<Account> _accounts;

        void AddToRepository(Account account)
        {
            _accounts.Add(account);
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

        public Guid FindUserByName(string username)
        {
            foreach (var account in _accounts)
            {
                if (account.Username.Equals(username))
                    return account.Id;
            }
            throw new Exception("User with such name is not found");
        }
    }
}
