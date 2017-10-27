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
    }
}
