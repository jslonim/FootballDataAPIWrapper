﻿using AutoMapper;
using FootballDataWrapper.Business.DTO;
using FootballDataWrapper.Business.Interfaces;
using FootballDataWrapper.Data.Domain;
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

        public void ImportLeague(string leagueCode)
        {

            //Get Competition
            CompetitionDTO competition = this.GetAsync<CompetitionItemDTO>(getAllCompetitions).Result
                                             .Competitions.FirstOrDefault(x => x.Code == leagueCode);

            //Get Team   
            List<TeamDTO> teams = this.GetAsync<CompetitionItemDTO>(getTeamByCompetition.Replace("{competitionId}", competition.Id.ToString())).Result.Teams;

            //Get Players
            List<PlayerDTO> players = new List<PlayerDTO>();

            foreach (var team in teams)
            {
                List<PlayerDTO> squad = this.GetAsync<TeamItemDTO>(getPlayersByTeam.Replace("{teamId}", team.Id.ToString())).Result.Squad;
                if (squad != null)
                {
                    squad.ForEach(x => x.TeamId = team.Id);
                    players.AddRange(squad);
                }

            }

            Competition comp = this.mapper.Map<Competition>(competition);
        }

    }
}