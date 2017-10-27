using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Leaguegram.Domain;
using Leaguegram.Infrastucture;
using Leaguegram.Common;
using Leaguegram.Exceptions;

namespace Leaguegram.UnitTests.Domain
{
    [TestClass]
    public class MultipleChatTests
    {
        // Tests for overloading methods 
        [TestMethod]
        [ExpectedException(typeof(AuthorCanNotBeDeletedException))]
        public void IfTryingToDeleteAuthorOfChat_DeleteParticipantFromChat_ShouldThrowException()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid authorId = Guid.NewGuid();
            Channel channel = new Channel(authorId, "title");
            Account admin = new Account("user", "password");
            channel.AddParticipant(authorId, admin.Id, Status.administrator);
            var chatId = channel.GetId();

            channel.DeleteParticipant(admin.Id, authorId);
        }

        [TestMethod]
        [ExpectedException(typeof(UserIsNotAuthorizedException))]
        public void IfUserIsUnauthorized_DeleteParticipantFromChat_ShouldThrowException()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid authorId = Guid.NewGuid();
            Channel channel = new Channel(authorId, "title");
            Account user = new Account("user", "password");
            channel.AddParticipant(authorId, user.Id);
            var chatId = channel.GetId();

            channel.DeleteParticipant(user.Id, authorId);
        }

        [TestMethod]
        [ExpectedException(typeof(UserIsNotAuthorizedException))]
        public void IfUserIsUnauthorized_AddParticipantToChat_ShouldThrowException()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid authorId = Guid.NewGuid();
            Channel channel = new Channel(authorId, "title");
            Account user = new Account("user", "password");
            channel.AddParticipant(authorId, user.Id);
            var chatId = channel.GetId();

            channel.AddParticipant(user.Id, authorId);
        }
        //end

        [TestMethod]
        [ExpectedException(typeof(UserIsNotAuthorizedException))]
        public void IfUserIsUnauthorized_ChangeUserStatus_ShouldThrowException()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid authorId = Guid.NewGuid();
            Channel channel = new Channel(authorId, "title");
            Account user = new Account("user", "password");
            channel.AddParticipant(authorId, user.Id);
            var chatId = channel.GetId();

            channel.ChangeUserStatus(user.Id, authorId);
        }

        [TestMethod]
        [ExpectedException(typeof(UserIsNotAuthorizedException))]
        public void IfUserIsUnauthorized_DeleteMessageFromChat_ShouldThrowException()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid id = Guid.NewGuid();
            Channel channel = new Channel(id, "title");
            var chatId = channel.GetId();
            Account account1 = new Account("user1", "");
            Account account2 = new Account("user2", "");
            account1.AddToDialogues(chatId, "");
            account2.AddToDialogues(chatId, "");
            channel.AddParticipant(account1.Id);
            channel.AddParticipant(account2.Id);
            var message = new Message("message", account1.Id);
            chatsRepository.AddMessageToChat(chatId, message);

            chatsRepository.DeleteMessageFromChat(chatId, account2.Id, message.Id);
        }
    }
}
