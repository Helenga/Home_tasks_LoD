using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Application
{
    internal class Author : Admin, IAuthor
    {
        public void AuthorizeUser(Guid userId, Guid chatId)
        {
            
        }

        public void DemoteUser(Guid userId, Guid chatId)
        {
            
        }
    }
}
