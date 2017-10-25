using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leaguegram.Common;

namespace Leaguegram.Domain
{
    class Dialogue : Chat
    {
        public Dialogue() : base()
        {
            _participants = new Dictionary<Guid, Status>(2);
        }
    }
}
