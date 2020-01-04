﻿using FootballDataWrapper.Data.Domain;
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

        private readonly IOptions<ConnectionStringOption> _connStrOptions;
        public FootballDataContext(IOptions<ConnectionStringOption> conStrOptions, DbContextOptions options) : base(options)
        {
            _connStrOptions = conStrOptions;

        }
        public FootballDataContext() : base()
        {
        }

        public DbSet<Competition> Competition { get; set; }

        public DbSet<CompetitionTeam> CompetitionTeam { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connStrOptions.Value.ConStr);
        }
    }
}
