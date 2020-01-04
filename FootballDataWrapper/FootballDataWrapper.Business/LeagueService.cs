﻿using FootballDataWrapper.Business.DTO.ExternalService;
using FootballDataWrapper.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballDataWrapper.Business
{
    public class LeagueService: BaseService , ILeagueService
    {
        #region Constants
        
        private const string getTeamByCompetition = "https://api.football-data.org/v2/competitions/{competitionId}/teams";
        private const string getAllCompetitions = "https://api.football-data.org/v2/competitions";
        private const string getPlayersByTeam = "https://api.football-data.org/v2/teams/{teamId}";
        
        #endregion

        public LeagueService(string _apiKey) : base(_apiKey)
        {        
        }

        public async void ImportLeague(string leagueCode) {
            
            //Get Competition
            CompetitionDTO competition = this.GetAsync<CompetitionItemDTO>(getAllCompetitions).Result
                                             .Competitions.FirstOrDefault(x=> x.Code == leagueCode);

            //Get Team   
            List<TeamDTO> teams = this.GetAsync<CompetitionItemDTO>(getTeamByCompetition.Replace("{competitionId}", competition.Id.ToString())).Result.Teams;

            //Get Players
        }
            
    }
}
