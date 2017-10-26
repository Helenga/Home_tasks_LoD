using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegram.Common;
using Leaguegram.Infrastucture;

namespace Leaguegram.Domain
{
    internal class Chat
    {
        public Chat()
        {
            _messagesRepository = new List<Message>();
            _id = new Guid();
            _chatsRepository.AddNewChatToRepository(this);
        }

        public List<Message> GetMessages()
        {
            return _messagesRepository;
        }

        public Guid GetId()
        {
            return _id;
        }

        public void AddMessage(Message message)
        {
            _messagesRepository.Add(message);
        }

        public void EditMessage(Guid id, string text)
        {
            FindMessageById(id).Body = text;
        }

        public void DeleteMessage(Guid id)
        {
            _messagesRepository.Remove(FindMessageById(id));
        }

        public void AddParticipant(Guid id, Status status = Status.user)
        {
            _participants.Add(id, status);
        }

        public void DeleteParticipant(Guid id)
        {
            _participants.Remove(id);
        }

        protected Message FindMessageById(Guid id)
        {
            foreach (Message message in _messagesRepository)
            {
                if (message.Id.Equals(id))
                    return message;
            }
            throw new Exception("Message doesn't exist");
        }

        protected Guid _id;
        protected Dictionary<Guid, Status> _participants;
        protected List<Message> _messagesRepository;

        private ChatsRepository _chatsRepository;
    }
}
