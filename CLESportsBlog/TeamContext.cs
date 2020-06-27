using CLESportsBlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLESportsBlog
{
    public class TeamContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Content> Contents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=CLESportsBlog;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
            new Team
            {
                Name = "Cavs",
                Id = 1,
                ImageLink = "./images/cavslogo.png"
            },
            new Team
            {
                Name = "Indians",
                Id = 2,
                ImageLink = "./images/indianslogo.png"
            },
            new Team
            {
                Name = "Browns",
                Id = 3,
                ImageLink = "./images/brownslogo.png"
            });

            modelBuilder.Entity<Content>().HasData(
            new Content
            {
                Id = 1,
                Title = "Cavs",
                Body = "Cavs Post",
                Author = "Lebron",
                PublishDate = DateTime.Now,
                TeamId = 1
            },
            new Content
            {
                Id = 2,
                Title = "Indians",
                Body = "Indinas Post",
                Author = "Lindor",
                PublishDate = DateTime.Now,
                TeamId = 2
            },
            new Content
            {
                Id = 3,
                Title = "Browns",
                Body = "Browns Post",
                Author = "Kosar",
                PublishDate = DateTime.Now,
                TeamId = 3
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
