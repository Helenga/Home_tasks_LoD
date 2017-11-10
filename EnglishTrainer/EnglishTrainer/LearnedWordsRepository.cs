namespace EnglishTrainer.Infrastructure
{
    internal class LearnedWordsRepository : ProgressRepository, IProgressRepository
    {
       public LearnedWordsRepository(string filePath) : base(filePath) { }
    }
}
