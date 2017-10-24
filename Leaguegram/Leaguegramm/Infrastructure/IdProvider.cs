using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegramm.Infrastructure
{
    class IdProvider
    {
        public Guid GetId()
        {
            Guid id = new Guid();
            return id;
        }
    }
}
