using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data
{
    public class PlayerRepository : BaseRepository<Player>
    {
        private readonly FootballDataContext context;
        public PlayerRepository(FootballDataContext _context) : base(_context)
        {
            context = _context;
        }
    }
}

