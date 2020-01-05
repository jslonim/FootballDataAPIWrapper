using FootballDataWrapper.Data.Interfaces.Domain;
using FootballDataWrapper.Data.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data.Contexts
{
    public class FootballDataContext : DbContext
    {
        public FootballDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Competition> Competition { get; set; }

        public DbSet<CompetitionTeam> CompetitionTeam { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }

    }
}
