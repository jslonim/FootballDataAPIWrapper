using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business.Interfaces
{
    public interface IPlayersService
    {
        string GetTotalPlayers(string leagueCode);
    }
}
