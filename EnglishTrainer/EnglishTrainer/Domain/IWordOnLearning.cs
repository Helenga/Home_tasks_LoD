namespace EnglishTrainer.Domain
{
    interface IWordOnLearning
    {
        void IncreaseCounter();

        bool NumberOfIterationsIsEnoughToConsiderWordIsLearned();
    }
}
