using System;
using System.Collections.Generic;
namespace EnglishTrainer.Domain
{
    interface IWordsHandler
    {
        void AddNewCombinationToLearn(KeyValuePair<string, string> combination);

        string FindTranslationOfWord(string word);

        bool WordIsLearned(string word);

        IList<WordOnLearning> GetWordsOnLearning();

        IDictionary<string, string> GetLearnedWords();

        void UpdateStatusOfWord(string word);
    }
}
