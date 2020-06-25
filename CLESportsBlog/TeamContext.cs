using CLESportsBlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
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
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Restaurants;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Team>().HasData(
                new Team()
                {
                    Name = "Cavs",
                    Id = 1,
                    ImageLink = "./images/cavslogo.png",
                },
                new Team()
                {
                    Name = "Indians",
                    Id = 2,
                    ImageLink = "./images/indianslogo.png"
                },
                new Team()
                {
                    Name = "Browns",
                    Id = 1,
                    ImageLink = "./images/brownslogo.png",
                });
            
        //base.OnModelCreating(modelBuilder));
    }
}
