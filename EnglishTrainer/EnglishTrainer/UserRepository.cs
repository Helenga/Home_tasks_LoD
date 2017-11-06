using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnglishTrainer.Domain;

namespace EnglishTrainer.Infrastructure
{
    class UserRepository : IUserRepository
    {
        public UserRepository(string filePath)
        {
            _filePath = filePath;
        }

        public Guid FindUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveNewUser(User newUser)
        {
            throw new NotImplementedException();
        }

        private string _filePath;
    }
}
