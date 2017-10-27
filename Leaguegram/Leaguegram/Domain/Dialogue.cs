using System;
using System.Collections.Generic;

using Leaguegram.Common;

namespace Leaguegram.Domain
{
    internal class Dialogue : Chat
    {
        public Dialogue(Guid userId, Guid receiverId) : base()
        {
            _participants = new Dictionary<Guid, Status>(2);
            AddParticipant(userId);
            AddParticipant(receiverId);
        }
    }
}
