using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligagram
{
    public abstract class Chat
    {
        public Guid Id;

        public void AddChart(Chat chat)
        {

        }
        public Message[] Messages { get; private set; }
        public ChatMember[] Members { get; }
        public void EditMessage(int messageId, string newMessage)
        {

        }

        public void SendMessage(Guid chatId, int senderId, string text)
        {
            if (!CanSendMessage(senderId))
            {
                throw new UnauthorizedAccessException();
            }
            var message = new Message(Guid.NewGuid(), messageId, text, senderId);
            var messageList = new List<Message>();
            messageList.Add(message);
        }

        private abstract CanSendMessage()
        {

        }
        protected bool 
    }
}
