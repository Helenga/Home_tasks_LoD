namespace EnglishTrainer.Infrastructure
{
    internal class WordsOnLearningRepository : ProgressRepository, IProgressRepository
    {
        public WordsOnLearningRepository(string filePath) : base(filePath) { }
    }
}
