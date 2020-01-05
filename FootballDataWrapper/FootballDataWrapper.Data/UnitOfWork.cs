using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FootballDataContext _context;

        public UnitOfWork(FootballDataContext context)
        {
            _context = context;
            Competitions = new CompetitionRepository(context);
            Players = new PlayerRepository(context);
            Teams = new TeamRepository(context);
            CompetitionTeams = new CompetitionTeamRepository(context);
        }

        public ICompetitionRepository Competitions { get; }

        public IPlayerRepository Players { get; }

        public ITeamRepository Teams { get; }

        public ICompetitionTeamRepository CompetitionTeams { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
