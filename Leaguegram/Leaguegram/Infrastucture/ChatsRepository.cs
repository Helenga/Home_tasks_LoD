using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

using Leaguegram.Domain;
using Leaguegram.Common;
using Leaguegram.Exceptions;

namespace Leaguegram.Infrastucture
{
    internal class ChatsRepository
    {
        static ChatsRepository()
        {
            _chats = new ArrayList();
        }

        public IEnumerable<Channel> FindChannelsByTitle(string stringforSearch)
        {
            List<Channel> foundChannels = new List<Channel>();
            foreach (Channel channel in _chats.OfType<Channel>())
            {
                if (channel.Title.Contains(stringforSearch))
                    foundChannels.Add(channel);
            }
            if (foundChannels.Count > 0)
                return foundChannels;
            else
                return null;
        }

        public IEnumerable<Message> SelectMessagesFromChat(Guid id)
        {
            var chat = FindChatById(id);
            return chat.GetMessages();
        }

        public void AddMessageToChat(Guid id, Message message)
        {
            var chat = FindChatById(id);
            chat.AddMessage(message);
        }

        public void EditMessageInChat(Guid chatId, Guid messageId, string newText)
        {
            var chat = FindChatById(chatId);
            chat.EditMessage(messageId, newText);
        }

        public void DeleteMessageFromChat(Guid chatId, Guid userId, Guid messageId)
        {
            
            var chat = FindChatById(chatId);
            
            chat.DeleteMessage(userId, messageId);
        }

        public void AddUserToChat(Guid chatId, Guid userId)
        {
            FindChatById(chatId).AddParticipant(userId);
        }

        public void DeleteUserFromChat(Guid chatId, Guid userId)
        {
            FindChatById(chatId).DeleteParticipant(userId);
        }

        // overloaded methods for authorized users queries
        public void AddUserToChat(Guid requestingUserId, Guid chatId, Guid userId)
        {
            (FindChatById(chatId) as MultipleChat).AddParticipant(requestingUserId, userId);
        }

        public void DeleteUserFromChat(Guid requestingUserId, Guid chatId, Guid userId)
        {
            (FindChatById(chatId) as MultipleChat).DeleteParticipant(requestingUserId, userId);
        }
        // end

        public void ChangeParticipantStatus(Guid requestingUserId, Guid userId, Guid chatId)
        {
            MultipleChat chat = FindChatById(chatId) as MultipleChat;
            chat.ChangeUserStatus(requestingUserId, userId);
        }

        public void AddNewChatToRepository<T>(T chat)
        {
            _chats.Add(chat);
        }

        private static ArrayList _chats;

        private Chat FindChatById(Guid id)
        {
            foreach (var chat in _chats)
            {
                var chatObj = chat as Chat;
                if (chatObj.GetId().Equals(id))
                {
                    return chatObj;
                }
            }
            throw new DialogueIsNotFoundException();
        }
    }
}
