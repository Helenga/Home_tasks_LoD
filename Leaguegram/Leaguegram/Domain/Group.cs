using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Domain
{
    class Group : MultipleChat
    {
        public Group(string title) : base(title)
        {
            Title = title;
        }
    }
}
