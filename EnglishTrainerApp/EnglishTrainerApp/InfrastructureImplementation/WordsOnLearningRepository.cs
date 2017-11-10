using EnglishTrainer.Infrastructure;

namespace EnglishTrainer.InfrastructureImplementation
{
    internal class WordsOnLearningRepository : ProgressRepository, IProgressRepository
    {
        public WordsOnLearningRepository(string filePath) : base(filePath) { }
    }
}
