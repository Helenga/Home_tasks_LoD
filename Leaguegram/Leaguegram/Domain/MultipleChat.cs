using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegram.Common;

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
                throw new Exception("User isn't authorized");
        }

        public void AddParticipant(Guid requestingUserId, Guid id, Status status = Status.user)
        {
            if (IsUserAdministrator(requestingUserId) || IsUserAuthor(requestingUserId))
                _participants.Add(id, status);
            else
                throw new Exception("User isn't authorized");
        }

        public void DeleteParticipant(Guid requestingUserId, Guid id)
        {
            if (IsUserAdministrator(requestingUserId) || IsUserAuthor(requestingUserId))
                _participants.Remove(id);
            else
                throw new Exception("User isn't authorized");
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
