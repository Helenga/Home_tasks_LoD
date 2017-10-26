using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leaguegram.Domain;

namespace Leaguegram.UnitTests.Infrastructure
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void ShowDialogues_ShouldReturnAddedDialogue()
        {
            Account account = new Account("username", "password");
            Guid chatId = Guid.NewGuid();
            account.AddToDialogues(chatId, "chat");

            List<string> expected = new List<string>();
            expected.Add("chat");

            var actual = account.ShowDialogues();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddToDialogues_ShouldAddDialogueToDialogues()
        {
            Account account = new Account("username", "password");
            Guid chatId = Guid.NewGuid();
            string title = "chat";
            account.AddToDialogues(chatId, title);

            var dialogues = account.ShowDialogues();

            CollectionAssert.Contains(dialogues, title);
        }

        [TestMethod]
        public void GetIdOfDialogue_ShouldReturnDialogueId_IfDialogueExists()
        {
            Account account = new Account("username", "password");
            Guid chatId = Guid.NewGuid();
            string title = "chat";
            account.AddToDialogues(chatId, title);

            Guid id = account.GetIdOfDialogue(title);

            Assert.AreEqual(chatId, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetIdOfDialogue_ShouldThrowException_IfDialogueDoesNotExist()
        {
            Account account = new Account("username", "password");
            string title = "chat";

            account.GetIdOfDialogue(title);
        }
    }
}