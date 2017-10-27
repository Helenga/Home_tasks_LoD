using System;

namespace Leaguegram.Exceptions
{
    internal class LeaguegramException : ApplicationException
    {
        public LeaguegramException() { }

        public LeaguegramException(string message) : base(message) { }
    }
}
