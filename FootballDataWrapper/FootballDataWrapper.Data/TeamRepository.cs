using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Domain;
using FootballDataWrapper.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        private readonly FootballDataContext context;
        public TeamRepository(FootballDataContext _context) : base(_context)
        {
            context = _context;
        }
    }
}

