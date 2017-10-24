using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegramm.Application.Interfaces
{
    interface IAuthor : IAdmin
    {
        void AuthorizeUser();
        void DemoteUser();
    }
}
