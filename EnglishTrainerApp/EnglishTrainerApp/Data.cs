using EnglishTrainer.Infrastructure;
using EnglishTrainer.Application;
using EnglishTrainer.Domain;

namespace EnglishTrainerApp
{
    static class Data
    {
        public static LearnedWordsRepository learnedWordsRepository =
                              new LearnedWordsRepository($"Repository/learnedWords.json");
        public static WordsOnLearningRepository wordsOnLearningRepository =
                              new WordsOnLearningRepository($"Repository/wordsOnLearning.json");
        public static DictionaryRepository dictionaryRepository =
                              new DictionaryRepository($"Repository/Dictionaries");
        public static UserService userService = new UserService(
                                  new UserRepository($"Repository/users.json"),
                                  learnedWordsRepository,
                                  wordsOnLearningRepository);

        public static TrainerService trainerService = new TrainerService(
            dictionaryRepository,
            learnedWordsRepository,
            wordsOnLearningRepository,
            new WordsHandler());
    }
}
