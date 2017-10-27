using System;

namespace Leaguegram.Domain
{
    internal class Group : MultipleChat
    {
        public Group(Guid CreatorId, string title) : base(CreatorId, title)
        {
            
        }
    }
}
