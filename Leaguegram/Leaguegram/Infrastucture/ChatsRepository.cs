using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegram.Domain;
using Leaguegram.Common;

namespace Leaguegram.Infrastucture
{
    internal class ChatsRepository
    {
        private ArrayList _chats;

        public void AddNewChatToRepository<T>(T chat)
        {
            _chats.Add(chat);
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

        public void DeleteMessage(Guid chatId, Guid messageId)
        {
            var chat = FindChatById(chatId);
            chat.DeleteMessage(messageId);
        }

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
            throw new Exception("Dialogue is not found");
        }

    }
}
