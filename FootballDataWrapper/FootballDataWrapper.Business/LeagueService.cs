﻿using AutoMapper;
using FootballDataWrapper.Business.DTO;
using FootballDataWrapper.Business.Exceptions;
using FootballDataWrapper.Business.Interfaces;
using FootballDataWrapper.Business.Utils;
using FootballDataWrapper.Data;
using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Interfaces.Domain;
using FootballDataWrapper.Data.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballDataWrapper.Business
{
    public class LeagueService : BaseService, ILeagueService
    {
        public LeagueService(IApiKey _apiKey, FootballDataContext _context) : base(_apiKey.Key, _context)
        {
        }

        public void ImportLeague(string leagueCode)
        {
            //Competition           
            CompetitionDTO competition = this.GetAsync<CompetitionItemDTO>(API_URL.GetAllCompetitions).Result.Competitions
                                             .FirstOrDefault(x => x.Code == leagueCode);
            if (competition == null)
            {
                throw new LeagueNotFoundException("Not found");
            }

            Competition competitionModel = this.mapper.Map<Competition>(competition);

            if (unitOfWork.Competitions.GetById(competition.Id) != null)
            {
                throw new LeagueImportedException("League already imported");
            }

            unitOfWork.Competitions.Add(competitionModel);

            //Team and Players
            List<TeamDTO> teams = this.GetAsync<CompetitionItemDTO>(API_URL.GetTeamsByCompetition.Replace("{competitionId}", competition.Id.ToString())).Result.Teams;
            List<PlayerDTO> players = new List<PlayerDTO>();

            if (teams.Count > 0)
            {
                List<Team> teamModelList = this.mapper.Map<List<Team>>(teams);

                foreach (Team teamModel in teamModelList)
                {
 
                    unitOfWork.CompetitionTeams.Add(new CompetitionTeam() { CompetitionId = competitionModel.CompetitionId, TeamId = teamModel.TeamId });

                    if (unitOfWork.Teams.GetById(teamModel.Id) == null)
                    {
                        //Only leave in the list the teams that are not already in DB, so the players don't get added twice either.
                        unitOfWork.Teams.Add(teamModel);

                        List<PlayerDTO> squad = this.GetAsync<TeamItemDTO>(API_URL.GetPlayersByTeam.Replace("{teamId}", teamModel.TeamId.ToString())).Result.Squad;

                        if (squad != null && squad.Count > 0)
                        {
                            squad.ForEach(x => x.TeamId = teamModel.TeamId);
                            players.AddRange(squad);
                        }                       
                    }
                }
                if (players.Count() > 1)
                {
                    List<Player> playerModelList = this.mapper.Map<List<Player>>(players);
                    unitOfWork.Players.AddRange(playerModelList);
                }
                
            }
            //Execute transaction
            this.CompleteTransaction();
        }

    }
}
