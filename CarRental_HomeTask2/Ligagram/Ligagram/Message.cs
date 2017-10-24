using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligagram
{
    public abstract class Message
    {
        public Message(int messageId, string text, int senderId)
        {
            MessageGuid = Guid.NewGuid();
            MessageId = messageId;
            Text = text;
            SenderID = senderId;
        }

        public Guid MessageGuid;
        public int MessageID { get; }
        public string Text { get; }
        public int SenderID { get; }


    }
}
