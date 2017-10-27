using System;
using System.Collections.Generic;

using Leaguegram.Common;
using Leaguegram.Infrastucture;
using Leaguegram.Exceptions;

namespace Leaguegram.Domain
{
    internal class Chat
    {
        public Chat()
        {
            _messagesRepository = new List<Message>();
            _id = Guid.NewGuid();
            _chatsRepository = new ChatsRepository();
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

        public virtual void DeleteMessage(Guid userId, Guid messageId)
        {
            var message = FindMessageById(messageId);
            if (message.SenderId.Equals(userId))
                _messagesRepository.Remove(message);
            else
                throw new UserIsNotAuthorizedException();
        }

        public void AddParticipant(Guid id, Status status = Status.user)
        {
            if (!_participants.ContainsKey(id))
                _participants.Add(id, status);
            else
                throw new ParticipantAlreadyExistException();
        }

        public void DeleteParticipant(Guid id)
        {
            if (_participants.ContainsKey(id))
                _participants.Remove(id);
            else
                throw new UserIsNotFoundException();
        }

        protected Message FindMessageById(Guid id)
        {
            foreach (Message message in _messagesRepository)
            {
                if (message.Id.Equals(id))
                    return message;
            }
            throw new MessageDoesNotExistException();
        }

        protected Guid _id;
        protected Dictionary<Guid, Status> _participants;
        protected List<Message> _messagesRepository;

        private ChatsRepository _chatsRepository;
    }
}
