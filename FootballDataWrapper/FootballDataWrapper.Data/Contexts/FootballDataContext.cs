using FootballDataWrapper.Data.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Data.Contexts
{
    public class FootballDataContext : DbContext
    {

        public DbSet<Competition> Competition { get; set; }

        public DbSet<CompetitionTeam> CompetitionTeam { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        //}
    }
}
