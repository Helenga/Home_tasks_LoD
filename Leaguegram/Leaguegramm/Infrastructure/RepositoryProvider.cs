using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegramm.Infrastructure
{
    class RepositoryProvider
    {
        public List<T> CreateRepository<T>()
        {
            List<T> repository = new List<T>();
            return repository;
        } 
    }
}
