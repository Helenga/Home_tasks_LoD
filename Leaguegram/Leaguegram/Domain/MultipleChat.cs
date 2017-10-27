using System;
using System.Collections.Generic;

using Leaguegram.Common;
using Leaguegram.Exceptions;

namespace Leaguegram.Domain
{
    internal class MultipleChat : Chat
    {
        public MultipleChat(Guid creatorId, string title) : base()
        {
            _participants = new Dictionary<Guid, Status>();
            Title = title;
            AddParticipant(creatorId, Status.author);
        }

        public void ChangeUserStatus(Guid requestingUserId, Guid userId)
        {
            if (IsUserAuthor(requestingUserId))
            {
                var status = _participants[userId];
                if (status.Equals(Status.user))
                    _participants[userId] = Status.administrator;
                else
                    _participants[userId] = Status.user;
            }
            else
                throw new UserIsNotAuthorizedException();
        }

        public void AddParticipant(Guid requestingUserId, Guid id, Status status = Status.user)
        {
            if (IsUserAdministrator(requestingUserId) || IsUserAuthor(requestingUserId))
                AddParticipant(id, status);
            else
                throw new UserIsNotAuthorizedException();
        }

        public void DeleteParticipant(Guid requestingUserId, Guid id)
        {
            if (IsUserAdministrator(requestingUserId) || IsUserAuthor(requestingUserId))
                if (!IsUserAuthor(id))
                    DeleteParticipant(id);
                else
                    throw new AuthorCanNotBeDeletedException();
            else
                throw new UserIsNotAuthorizedException();
        }

        public override void DeleteMessage(Guid userId, Guid messageId)
        {
            if (IsUserAdministrator(userId) || IsUserAuthor(userId))
                _messagesRepository.Remove(FindMessageById(messageId));
            else
                throw new UserIsNotAuthorizedException();
        }

        protected bool IsUserAuthor(Guid userId)
        {
            return _participants[userId].Equals(Status.author);
        }

        protected bool IsUserAdministrator(Guid userId)
        {
            return _participants[userId].Equals(Status.administrator);
        }

        public string Title { get; protected set; }
    }
}
