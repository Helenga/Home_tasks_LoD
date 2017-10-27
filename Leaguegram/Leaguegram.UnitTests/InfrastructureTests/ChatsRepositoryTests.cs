using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Leaguegram.Domain;
using Leaguegram.Infrastucture;
using Leaguegram.Common;
using Leaguegram.Exceptions;

namespace Leaguegram.UnitTests.Infrastructure
{
    [TestClass]
    public class ChatsRepositoryTests
    {
        [TestMethod]
        public void FindChannelsByTytle_ShouldReturnNull_IfPassedStringIsNotContainedInChannelTitle()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid id = Guid.NewGuid();
            string title = "channel";
            Channel channel = new Channel(id, title);
            List<Channel> expected = new List<Channel>() { channel };
            var result = chatsRepository.FindChannelsByTitle("title");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void FindChannelsByTitle_ShouldReturnChannel_IfPassedStringIsContainedInChannelTitle()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid id = Guid.NewGuid();
            var title = "channel";
            Channel channel = new Channel(id, title);
            List<Channel> expected = new List<Channel>() { channel };
            var actual = chatsRepository.FindChannelsByTitle("chan");

            Assert.AreEqual(channel, actual.Last());
        }

        [TestMethod]
        public void AfterCalling_AddMessageToChat_SelectMessagesFromChat_ShouldReturnAddedMessage()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid id = Guid.NewGuid();
            Channel channel = new Channel(id, "title");
            var chatId = channel.GetId();
            var message = new Message("message", id);
            chatsRepository.AddMessageToChat(chatId, message);

            var result = chatsRepository.SelectMessagesFromChat(chatId);
            CollectionAssert.Contains(result.ToList(), message);
        }

        [TestMethod]
        public void AfterCalling_EditMessageInChat_SelectMessagesFromChat_ShouldReturnUpdatedMessage()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid id = Guid.NewGuid();
            Channel channel = new Channel(id, "title");
            var chatId = channel.GetId();
            var message = new Message("message", id);
            chatsRepository.AddMessageToChat(chatId, message);
            chatsRepository.EditMessageInChat(chatId, message.Id, "edited");
            message.Body = "edited";

            var result = chatsRepository.SelectMessagesFromChat(chatId);
            CollectionAssert.Contains(result.ToList(), message);
        }

        [TestMethod]
        public void AfterCalling_DeleteMessageFromChat_SelectMessagesFromChat_ShouldNotReturnDeletedMessages()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid id = Guid.NewGuid();
            Channel channel = new Channel(id, "title");
            var chatId = channel.GetId();
            var message = new Message("message", id);
            chatsRepository.AddMessageToChat(chatId, message);

            chatsRepository.DeleteMessageFromChat(chatId, id, message.Id);
            var result = chatsRepository.SelectMessagesFromChat(chatId);
            CollectionAssert.DoesNotContain(result.ToList(), message);
        }

        [TestMethod]
        [ExpectedException(typeof(UserIsNotAuthorizedException))]
        public void IfUserIsTryingDeleteNotOwnMessage_DeleteMessageFromChat_ShouldThrowException()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Account account1 = new Account("user1", "");
            Account account2 = new Account("user2", "");
            Dialogue dialogue = new Dialogue(account1.Id, account2.Id);
            account1.AddToDialogues(dialogue.GetId(), "");
            account2.AddToDialogues(dialogue.GetId(), "");
            var message = new Message("message", account1.Id);
            chatsRepository.AddMessageToChat(dialogue.GetId(), message);

            chatsRepository.DeleteMessageFromChat(dialogue.GetId(), account2.Id, message.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(DialogueIsNotFoundException))]
        public void IfCalling_AddMessageToChat_PassWrongChatId_FindChatById_ShouldThrowException()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid id = Guid.NewGuid();
            Channel channel = new Channel(id, "title");
            var wrongId = Guid.NewGuid();
            var message = new Message("message", id);
            chatsRepository.AddMessageToChat(wrongId, message);
        }

    }
}