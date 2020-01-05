using FootballDataWrapper.Business.DTO;
using FootballDataWrapper.Business.Exceptions;
using FootballDataWrapper.Business.Interfaces;
using FootballDataWrapper.Business.Utils;
using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Interfaces.Domain;
using FootballDataWrapper.Data.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballDataWrapper.Business
{
    public class PlayersService : BaseService, IPlayersService
    {
        public PlayersService(IApiKey _apiKey, FootballDataContext _context) : base(_apiKey.Key, _context)
        {

        }
        public string GetTotalPlayers(string leagueCode) 
        {
            //Competition           
            Competition competition = unitOfWork.Competitions.Find(x => x.Code == leagueCode).FirstOrDefault();

            if (competition == null)
            {
                throw new LeagueNotFoundException("Not found");
            }

            //Return count of players
            return (from team in unitOfWork.Teams.GetAll()
                    join competitionTeam in unitOfWork.CompetitionTeams.GetAll()
                    on team.TeamId equals competitionTeam.TeamId
                    join players in unitOfWork.Players.GetAll()
                    on team.TeamId equals players.TeamId
                    where competitionTeam.CompetitionId == competition.CompetitionId
                    select players).Count().ToString();
        }
    }
}
