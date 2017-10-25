using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Application
{
    interface IAuthor : IAdmin
    {
        void AuthorizeUser(Guid userId);
        void DemoteUser(Guid userId);
    }
}
