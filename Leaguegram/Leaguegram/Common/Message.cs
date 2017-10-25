using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Common
{
    internal class Message
    {
        public Message(string text, Guid sender)
        {
            Body = text;
            PostDate = DateTime.Now;
            SenderId = sender;
        }

        public Guid Id { get; }
        public Guid SenderId { get; }
        public string Body { get; set; }
        public DateTime PostDate { get; }
    }
}
