using EnglishTrainer.Infrastructure;

namespace EnglishTrainer.InfrastructureImplementation
{
    internal class LearnedWordsRepository : ProgressRepository, IProgressRepository
    {
       public LearnedWordsRepository(string filePath) : base(filePath) { }
    }
}
