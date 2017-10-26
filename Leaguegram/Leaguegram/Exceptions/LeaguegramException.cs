using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaguegram.Exceptions
{
    internal class LeaguegramException : ApplicationException
    {
        public LeaguegramException() { }

        public LeaguegramException(string message) : base(message) { }
    }
}
