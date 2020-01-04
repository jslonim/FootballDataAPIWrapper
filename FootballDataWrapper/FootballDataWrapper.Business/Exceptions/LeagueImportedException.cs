using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business.Exceptions
{
    public class LeagueImportedException : Exception
    {
        public LeagueImportedException()
        {
        }

        public LeagueImportedException(string message)
            : base(message)
        {
        }

        public LeagueImportedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
