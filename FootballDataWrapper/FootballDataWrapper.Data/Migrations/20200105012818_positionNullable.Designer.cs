﻿// <auto-generated />
using System;
using FootballDataWrapper.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FootballDataWrapper.Data.Migrations
{
    [DbContext(typeof(FootballDataContext))]
    [Migration("20200105012818_positionNullable")]
    partial class positionNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FootballDataWrapper.Data.Interfaces.Domain.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaName")
                        .HasMaxLength(200);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<int>("CompetitionId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Competition");
                });

            modelBuilder.Entity("FootballDataWrapper.Data.Interfaces.Domain.CompetitionTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetitionId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("CompetitionTeam");
                });

            modelBuilder.Entity("FootballDataWrapper.Data.Interfaces.Domain.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryOfBirth")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("PlayerId");

                    b.Property<string>("Position")
                        .HasMaxLength(50);

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("FootballDataWrapper.Data.Interfaces.Domain.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaName")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ShortName")
                        .HasMaxLength(150);

                    b.Property<string>("TLA")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
