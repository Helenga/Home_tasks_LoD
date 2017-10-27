using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Leaguegram.Domain;
using Leaguegram.Infrastucture;
using Leaguegram.Exceptions;

namespace Leaguegram.UnitTests.Infrastructure
{
    [TestClass]
    class ChatTests
    {
        // Other methods are tested in ChatsRepositoryTests class 
        // due to the logical dependence 

        [TestMethod]
        [ExpectedException(typeof(ParticipantAlreadyExistException))]
        public void WhenAddingAlreadyParticipatingUserToChat_AddParticipantToChat_ShouldThrowException()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid id = Guid.NewGuid();
            Channel channel = new Channel(id, "title");
            var chatId = channel.GetId();
            Account user = new Account("user", "password");

            chatsRepository.AddUserToChat(chatId, user.Id);
            chatsRepository.AddUserToChat(chatId, user.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(UserIsNotFoundException))]
        public void WhenDeletingAbsenteeUserToChat_DeleteParticipantFromChat_ShouldThrowException()
        {
            ChatsRepository chatsRepository = new ChatsRepository();
            Guid id = Guid.NewGuid();
            Channel channel = new Channel(id, "title");
            Guid absenteeId = new Guid();
            var chatId = channel.GetId();

            chatsRepository.DeleteUserFromChat(chatId, absenteeId);
        }
    }
}
