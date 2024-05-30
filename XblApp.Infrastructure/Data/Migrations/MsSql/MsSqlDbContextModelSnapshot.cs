﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XblApp.Infrastructure.Data;

#nullable disable

namespace XblApp.Infrastructure.Data.Migrations.MsSql
{
    [DbContext(typeof(MsSqlDbContext))]
    partial class MsSqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("nba")
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("XblApp.Domain.Entities.Game", b =>
                {
                    b.Property<long>("GameId")
                        .HasColumnType("bigint");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalAchievements")
                        .HasColumnType("int");

                    b.Property<int>("TotalGamerscore")
                        .HasColumnType("int");

                    b.HasKey("GameId");

                    b.ToTable("Games", "nba");
                });

            modelBuilder.Entity("XblApp.Domain.Entities.Gamer", b =>
                {
                    b.Property<long>("GamerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gamerscore")
                        .HasColumnType("int");

                    b.Property<string>("Gamertag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GamerId");

                    b.ToTable("Gamers", "nba");
                });

            modelBuilder.Entity("XblApp.Domain.Entities.GamerGame", b =>
                {
                    b.Property<long>("GamerId")
                        .HasColumnType("bigint");

                    b.Property<long>("GameId")
                        .HasColumnType("bigint");

                    b.Property<int>("CurrentAchievements")
                        .HasColumnType("int");

                    b.Property<int>("CurrentGamerscore")
                        .HasColumnType("int");

                    b.HasKey("GamerId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("GamerGame", "nba");
                });

            modelBuilder.Entity("XblApp.Domain.Entities.TokenOAuth", b =>
                {
                    b.Property<string>("AspNetUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccessToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthenticationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpiresIn")
                        .HasColumnType("int");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scope")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AspNetUserId");

                    b.ToTable("OAuthTokens", "nba");
                });

            modelBuilder.Entity("XblApp.Domain.Entities.TokenXau", b =>
                {
                    b.Property<string>("AspNetUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("IssueInstant")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NotAfter")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uhs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AspNetUserId");

                    b.ToTable("XauTokens", "nba");
                });

            modelBuilder.Entity("XblApp.Domain.Entities.TokenXsts", b =>
                {
                    b.Property<string>("AspNetUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AgeGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gamertag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IssueInstant")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NotAfter")
                        .HasColumnType("datetime2");

                    b.Property<string>("Privileges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPrivileges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Userhash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xuid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AspNetUserId");

                    b.ToTable("XstsTokens", "nba");
                });

            modelBuilder.Entity("XblApp.Domain.Entities.GamerGame", b =>
                {
                    b.HasOne("XblApp.Domain.Entities.Game", "Game")
                        .WithMany("GamerLinks")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XblApp.Domain.Entities.Gamer", "Gamer")
                        .WithMany("GameLinks")
                        .HasForeignKey("GamerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Gamer");
                });

            modelBuilder.Entity("XblApp.Domain.Entities.Game", b =>
                {
                    b.Navigation("GamerLinks");
                });

            modelBuilder.Entity("XblApp.Domain.Entities.Gamer", b =>
                {
                    b.Navigation("GameLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
