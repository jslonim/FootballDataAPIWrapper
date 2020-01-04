using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Interfaces;
using FootballDataWrapper.Data.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data
{
    public class PlayerRepository : BaseRepository<Player>,IPlayerRepository
    {
        private readonly FootballDataContext context;
        public PlayerRepository(FootballDataContext _context) : base(_context)
        {
            context = _context;
        }
    }
}

