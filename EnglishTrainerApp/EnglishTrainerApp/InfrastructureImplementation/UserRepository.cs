using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

using EnglishTrainer.Domain;
using EnglishTrainer.Infrastructure;

namespace EnglishTrainer.InfrastructureImplementation
{
    internal class UserRepository : IUserRepository
    {
        public UserRepository(string filePath)
        {
            _filePath = filePath;
        }

        public Guid FindUserByName(string name)
        {
            var users = LoadUsers();
            var foundUser = users.First(user => user.Name == name);
            return foundUser.Id;
        }

        public void SaveNewUser(User newUser)
        {
            var users = LoadUsers();
            users.Add(newUser);
            SaveUsers(users);
        }

        private List<User> LoadUsers()
        {
            try
            {
                var raws = File.ReadAllText(_filePath);
                if (raws == "")
                    return new List<User>();
                var users = JsonConvert.DeserializeObject<List<User>>(raws);
                return users;
            }
            catch (FileNotFoundException)
            {
                return new List<User>();
            }
        }

        private void SaveUsers(List<User> users)
        {
            var serialized = JsonConvert.SerializeObject(users);
            File.WriteAllText(_filePath, serialized);
        }

        private string _filePath;
    }
}
