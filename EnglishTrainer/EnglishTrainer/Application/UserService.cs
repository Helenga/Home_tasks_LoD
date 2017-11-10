using System;

using EnglishTrainer.Domain;
using EnglishTrainer.Infrastructure;

namespace EnglishTrainer.Application
{
    internal class UserService : IUserService
    {
        /*public UserService(IUserRepository userRepository, 
                           ILearnedWordsRepository learnedWordsRepository,
                           IWordsOnLearningRepository wordsOnLearningRepository)
        {
            _userRepository = userRepository;
            _learnedWordsRepository = learnedWordsRepository;
            _wordsOnLearningRepository = wordsOnLearningRepository;
        }*/

        public UserService(UserRepository userRepository, LearnedWordsRepository learnedWordsRepository, WordsOnLearningRepository wordsOnLearningRepository)
        {
            _userRepository = userRepository;
            _learnedWordsRepository = learnedWordsRepository;
            _wordsOnLearningRepository = wordsOnLearningRepository;
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

        /*private readonly IUserRepository _userRepository;
        private readonly ILearnedWordsRepository _learnedWordsRepository;
        private readonly IWordsOnLearningRepository _wordsOnLearningRepository;*/
        private UserRepository _userRepository;
        private LearnedWordsRepository _learnedWordsRepository;
        private WordsOnLearningRepository _wordsOnLearningRepository;
    }
}
