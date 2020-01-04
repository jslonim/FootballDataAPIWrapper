using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business.Exceptions
{
    public class LeagueNotFoundException : Exception
    {
        public LeagueNotFoundException()
        {
        }

        public LeagueNotFoundException(string message)
            : base(message)
        {
        }

        public LeagueNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
