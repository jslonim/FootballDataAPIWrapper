using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICompetitionRepository Competitions { get; }

        IPlayerRepository Players { get; }

        ITeamRepository Teams { get; }

        ICompetitionTeamRepository CompetitionTeams { get; }

        int Complete();
    }
}
