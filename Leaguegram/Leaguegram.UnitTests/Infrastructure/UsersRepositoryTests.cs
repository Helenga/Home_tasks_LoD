using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leaguegram.Domain;
using Leaguegram.Infrastucture;
using Leaguegram.Exceptions;

namespace Leaguegram.UnitTests.Infrastructure
{
    [TestClass]
    public class UsersRepositoryTests
    {
        [TestMethod]
        public void FindAccountsByStringForSearch_ShouldReturnAccount_IfUsernameContainsString()
        {
            UsersRepository usersRepository = new UsersRepository();
            Account account = new Account("user", "password");

            List<Account> expected = new List<Account>() { account };
            var actual = usersRepository.FindAccountsByStringForSearch("us");

            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod]
        public void FindAccountsByStringForSearch_ShouldReturnNull_IfNoUsernamesContainString()
        {
            UsersRepository usersRepository = new UsersRepository();
            Account account = new Account("user", "password");

            var result = usersRepository.FindAccountsByStringForSearch("adm");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void FindUserIdByName_ShouldReturnUserId_IfPassedNameIsFound()
        {
            UsersRepository usersRepository = new UsersRepository();
            Account account = new Account("user", "password");

            var actual = usersRepository.FindUserIdByName("user");
            Assert.AreEqual(account.Id, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(UserIsNotFoundException))]
        public void FindUserIdByName_ShouldReturnNull_IfPassedNameIsNotFound()
        {
            UsersRepository usersRepository = new UsersRepository();
            Account account = new Account("user", "password");

            var result = usersRepository.FindUserIdByName("admin");
            Assert.IsNull(result);
        }
    }
}
