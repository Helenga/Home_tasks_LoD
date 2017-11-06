using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

using EnglishTrainer.Domain;

namespace EnglishTrainer.UnitTests
{
    [TestClass]
    public class WordOnLearningTests
    {
        [TestMethod]
        public void NumberOfIterationsIsEnoughToConsiderWordIsLearned_ReturnsFalse_AfterWordWasCreated()
        {
            var fixture = new Fixture();
            var word = fixture.Create<WordOnLearning>();
            Assert.IsFalse(word.NumberOfIterationsIsEnoughToConsiderWordIsLearned());
        }

        [TestMethod]
        public void NumberOfIterationsIsEnoughToConsiderWordIsLearned_ReturnsTrue_AfterIncreaseCounterWasCalledThreeTimes()
        {
            var fixture = new Fixture();
            var word = fixture.Create<WordOnLearning>();
            for (var i = 1; i <= 3; i++)
                word.IncreaseCounter();
            Assert.IsTrue(word.NumberOfIterationsIsEnoughToConsiderWordIsLearned());
        }
    }
}
