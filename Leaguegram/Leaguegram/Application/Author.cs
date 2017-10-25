using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Application
{
    class Author : Admin, IAuthor
    {
        public void AuthorizeUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void DemoteUser(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
