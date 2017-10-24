using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Есть три вида чата: канал, группа и приватный чат. В канал может писать только автор, в группу - все члены члены группы, в приватный чат - оба собеседника. Сообщения в чате можно редактировать и удалять. Причём в группе администраторы могут удалять чьи угодно сообщения, но редактировать - только свои.
    */
namespace Ligagram
{
    public class LeagueGram
    {
        public LeagueGram(ChatFactory chatFactory)
        {
            chatFactory = newChatFactory;
        }

        public void SendMessage(Guid chatId, int senderId, string text)
        {
            var chat = _chats[chatId];
            chat.SendMessage(text, senderId);
        }

        public ChatFactory chatFactory { get; }
        private readonly Dictionary<Guid, Chat> _chats; 
    }

    /*
    public abstract class Chat
    {
        public Message Messages { get; }

        public void SendMessage(string message, int )
        {

        }

        public void DeleteMessage()
        {

        }
    } */
}
