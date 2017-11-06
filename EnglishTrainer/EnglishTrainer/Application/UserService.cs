using System;

using EnglishTrainer.Domain;
using EnglishTrainer.Infrastructure;

namespace EnglishTrainer.Application
{
    internal class UserService : IUserService
    {
        public UserService(IUserRepository userRepository, 
                           IProgressRepository progressRepository)
        {
            _userRepository = userRepository;
            _learnedWordsRepository = progressRepository;
            _wordsOnLearningRepository = progressRepository;
        }

        public Guid Login(string name)
        {
            var userId = _userRepository.FindUserByName(name);
            return userId;
        }

        public Guid Registrate(string name)
        {
            var id = Guid.NewGuid();
            User newUser = new User(id, name);
            _userRepository.SaveNewUser(newUser);
            return id;
        }

        private readonly IUserRepository _userRepository;
        private readonly IProgressRepository _learnedWordsRepository;
        private readonly IProgressRepository _wordsOnLearningRepository;
    }
}
