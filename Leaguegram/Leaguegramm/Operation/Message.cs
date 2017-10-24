using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegramm.Operation
{
    public class Message
    {
        dynamic _sender;
        private string _body;
        private DateTime _postDate;

        Message Create<T>(T sender, string text)
        {
            Message message = new Message();
            message._sender = sender;
            message._body = text;
            message._postDate = DateTime.Now;
            return message;
        }

        Message Edit(string text)
        {
            _body = text;
            return this;
        }

        void Delete()
        {

        }
    }
}
