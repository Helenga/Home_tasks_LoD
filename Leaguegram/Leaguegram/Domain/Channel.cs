using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Domain
{
    internal class Channel : MultipleChat
    {
        public Channel(Guid CreatorId, string title) : base(CreatorId, title)
        {

        }
    }
}
