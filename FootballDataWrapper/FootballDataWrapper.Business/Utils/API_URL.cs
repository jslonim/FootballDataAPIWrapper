using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business.Utils
{
    public static class API_URL
    {
        public static string GetTeamByCompetition = "https://api.football-data.org/v2/competitions/{competitionId}/teams";
        public static string GetAllCompetitions = "https://api.football-data.org/v2/competitions";
        public static string GetPlayersByTeam = "https://api.football-data.org/v2/teams/{teamId}";
    }
}
