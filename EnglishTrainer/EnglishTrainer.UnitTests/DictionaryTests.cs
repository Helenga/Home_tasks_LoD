using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using System.Collections.Generic;

using EnglishTrainer.Domain;

namespace EnglishTrainer.UnitTests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void GetRandomPairOfWordAndItsTranslation_ReturnedValueIsNotNull()
        {
            var fixture = new Fixture();
            var dictionary = fixture.Create<Dictionary>();
            var pair = dictionary.GetRandomPairOfWordAndItsTranslation();
            Assert.IsNotNull(pair);
        }

        [TestMethod]
        public void GetRandomTranslation_ReturnedValueIsNotNull()
        {
            var fixture = new Fixture();
            var dictionary = fixture.Create<Dictionary>();
            var translation = dictionary.GetRandomTranslation();
            Assert.IsNotNull(translation);
        }

        [TestMethod]
        public void WordsEnded_ReturnFalse_IfWordsAreNotEmpty()
        {
            var fixture = new Fixture();
            var words = fixture.Create<Dictionary<string, string>>();
            fixture.AddManyTo(words);
            var dictionary = new Dictionary(words);
            Assert.IsFalse(dictionary.WordsEnded());
        }

        [TestMethod]
        public void WordsEnded_ReturnTrue_IfAllWordsAreDeleted()
        {
            var fixture = new Fixture();
            var words = fixture.Create<Dictionary<string, string>>();
            words.Clear();
            words.Add("word", "translation");
            var dictionary = new Dictionary(words);
            dictionary.DeleteLearnedWord("word");
            Assert.IsTrue(dictionary.WordsEnded());
        }
    }
}
