using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegramm.Domain
{
    class MultipleChat : Chat
    {
        public string Title { get; private set; }
        private readonly string _id;

        public void Create(string title)
        {
            MultipleChat chat = new Chat();
            chat.Title = title;
        }
    }
}
