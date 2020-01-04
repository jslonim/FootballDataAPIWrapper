using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Domain;
using FootballDataWrapper.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data
{
    public class CompetitionRepository : BaseRepository<Competition>, ICompetitionRepository
    {
        private readonly FootballDataContext context;
        public CompetitionRepository(FootballDataContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
