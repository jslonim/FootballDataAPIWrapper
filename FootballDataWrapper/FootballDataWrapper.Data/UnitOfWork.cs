﻿using FootballDataWrapper.Data.Contexts;
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
            Competitions = new CompetitionRepository(_context);
            Players = new PlayerRepository(_context);
            Teams = new TeamRepository(_context);
            CompetitionTeams = new CompetitionTeamRepository(_context);
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
