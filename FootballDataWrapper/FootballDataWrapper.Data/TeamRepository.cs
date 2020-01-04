using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data
{
    public class TeamRepository : BaseRepository<Team>
    {
        private readonly FootballDataContext context;
        public TeamRepository(FootballDataContext _context) : base(_context)
        {
            context = _context;
        }
    }
}

