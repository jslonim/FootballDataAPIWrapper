using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Interfaces;
using FootballDataWrapper.Data.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data
{
    public class CompetitionTeamRepository : BaseRepository<CompetitionTeam>, ICompetitionTeamRepository
    {
        private readonly FootballDataContext context;
        public CompetitionTeamRepository(FootballDataContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
