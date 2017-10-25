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
        public MultipleChat(string title) : base()
        {
            _participants = new Dictionary<Guid, Status>();
            Title = title;
        }

        public string Title { get; protected set; }
    }
}
