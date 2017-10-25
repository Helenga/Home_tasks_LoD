using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegram.Domain;

namespace Leaguegram.Infrastucture
{
    public class UsersRepository
    {
        private List<Account> _accounts;

        void AddToRepository(Account account)
        {
            _accounts.Add(account);
        }

        public IEnumerable<Account> FindAccountsByUserName(string stringForSearch)
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
    }
}
