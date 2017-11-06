using System.Collections.Generic;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

using EnglishTrainer.Domain;

namespace EnglishTrainer.UnitTests
{
    [TestClass]
    public class WordsHandlerTests
    {
        [TestMethod]
        public void AddNewCombinationToLearn_AddsNewCombinationToWordsOnLearning()
        {
            var fixture = new Fixture();
            var wordsHandler = fixture.Create<WordsHandler>();
            var combination = fixture.Create<KeyValuePair<string, string>>();
            WordOnLearning wordOnLearning = new WordOnLearning(combination);
            wordsHandler.AddNewCombinationToLearn(combination);
            var result = wordsHandler.GetWordsOnLearning();
            CollectionAssert.Contains(((ICollection)result), wordOnLearning);
        }

        [TestMethod]
        public void UpdateStatusOfWord_ReplacesWordFromOnLearningToLearnedList_AfterThreeCalls()
        {
            var fixture = new Fixture();
            var wordsHandler = fixture.Create<WordsHandler>();
            var combination = fixture.Create<KeyValuePair<string, string>>();
            WordOnLearning wordOnLearning = new WordOnLearning(combination);
            wordsHandler.AddNewCombinationToLearn(combination);
            for(var i = 1; i <= 3; i++)
                wordsHandler.UpdateStatusOfWord(combination.Key);
            var result = wordsHandler.GetLearnedWords();
            CollectionAssert.Contains((ICollection)result, combination);
        }

        [TestMethod]
        public void FindTranslationOfWord_ReturnsActualTranslationOfWord()
        {
            var fixture = new Fixture();
            var wordsHandler = fixture.Create<WordsHandler>();
            var combination = fixture.Create<KeyValuePair<string, string>>();
            WordOnLearning wordOnLearning = new WordOnLearning(combination);
            wordsHandler.AddNewCombinationToLearn(combination);

            Assert.AreEqual(wordsHandler.FindTranslationOfWord(combination.Key), combination.Value);
        }

        [TestMethod]
        public void WordIsLearned_ReturnsTrue_IfWordWasMoovedInLearnedWordsList()
        {
            var fixture = new Fixture();
            var wordsHandler = fixture.Create<WordsHandler>();
            var combination = fixture.Create<KeyValuePair<string, string>>();
            WordOnLearning wordOnLearning = new WordOnLearning(combination);
            wordsHandler.AddNewCombinationToLearn(combination);
            for (var i = 1; i <= 3; i++)
                wordsHandler.UpdateStatusOfWord(combination.Key);
            var result = wordsHandler.GetLearnedWords();
            Assert.IsTrue(wordsHandler.WordIsLearned(combination.Key));
        }
    }
}
