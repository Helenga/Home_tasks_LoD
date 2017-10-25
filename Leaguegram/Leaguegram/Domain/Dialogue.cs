﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
