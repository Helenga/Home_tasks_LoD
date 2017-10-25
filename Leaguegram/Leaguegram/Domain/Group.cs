using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Domain
{
    internal class Group : MultipleChat
    {
        public Group(Guid CreatorId, string title) : base(CreatorId, title)
        {
            
        }
    }
}
