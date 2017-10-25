using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Domain
{
    class Channel : MultipleChat
    {
        public Channel(string title) : base(title)
        {
            Title = title;
        }
    }
}
