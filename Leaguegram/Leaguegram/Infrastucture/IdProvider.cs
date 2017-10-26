using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Infrastucture
{
    internal class IdProvider
    {
        public static Guid GetId()
        {
            
            Guid id = Guid.NewGuid();
            return id;
        }
    }
}
