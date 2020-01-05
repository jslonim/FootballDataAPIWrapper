using AutoMapper;
using FootballDataWrapper.Business.DTO;
using FootballDataWrapper.Business.Exceptions;
using FootballDataWrapper.Business.Interfaces;
using FootballDataWrapper.Data;
using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballDataWrapper.Business
{
    public class LeagueService: BaseService , ILeagueService
    {
        #region Constants
        //This is the only place that uses these addresses, in case it's needed anywhere else it can be moved.
        private const string getTeamByCompetition = "https://api.football-data.org/v2/competitions/{competitionId}/teams";
        private const string getAllCompetitions = "https://api.football-data.org/v2/competitions";
        private const string getPlayersByTeam = "https://api.football-data.org/v2/teams/{teamId}";
        #endregion
        
        public LeagueService(string _apiKey) : base(_apiKey)
        {        
        }

        public void ImportLeague(string leagueCode)
        {
            //Competition           
            CompetitionDTO competition = this.GetAsync<CompetitionItemDTO>(getAllCompetitions).Result
                                             .Competitions.FirstOrDefault(x => x.Code == leagueCode);
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

            //Teams           
            List<TeamDTO> teams = this.GetAsync<CompetitionItemDTO>(getTeamByCompetition.Replace("{competitionId}", competition.Id.ToString())).Result.Teams;

            List<Team> teamModelList = this.mapper.Map<List<Team>>(teams);

            foreach (Team teamModel in teamModelList)
            {
                if (unitOfWork.Teams.GetById(teamModel.Id) == null)
                {
                    unitOfWork.Teams.Add(teamModel);
                }
                unitOfWork.CompetitionTeams.Add(new CompetitionTeam() { CompetitionId = competitionModel.CompetitionId , TeamId = teamModel.TeamId});
            }


            //Players
            List<PlayerDTO> players = new List<PlayerDTO>();

            foreach (TeamDTO team in teams)
            {
                List<PlayerDTO> squad = this.GetAsync<TeamItemDTO>(getPlayersByTeam.Replace("{teamId}", team.Id.ToString())).Result.Squad;
                if (squad != null)
                {
                    squad.ForEach(x => x.TeamId = team.Id);
                    players.AddRange(squad);
                }

            }

            List<Player> playerModelList = this.mapper.Map<List<Player>>(players);

            unitOfWork.Players.AddRange(playerModelList);

            //Execute transaction
            this.CompleteTransaction();

        }

    }
}
