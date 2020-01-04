using FootballDataWrapper.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business
{
    public class LeagueService : ILeagueService
    {
        #region Constants
        
        private const string getCompetition = "https://api.football-data.org/v2/competitions/{competitionId}/teams";
        private const string getAllCompetition = "https://api.football-data.org/v2/competitions";
        private const string getTeam = "https://api.football-data.org/v2/teams/{teamId}";
        
        #endregion

        private string apiKey;

        public LeagueService(string _apiKey)
        {
            apiKey = _apiKey;
        }
        public void ImportLeague(string leagueCode) { 
            
        }
            
    }
}
