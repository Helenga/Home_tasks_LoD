using System;

namespace Leaguegram.Domain
{
    internal class Channel : MultipleChat
    {
        public Channel(Guid CreatorId, string title) : base(CreatorId, title)
        {

        }
    }
}
