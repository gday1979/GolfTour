namespace GolfTour.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Models;

    public class PlayerSeeder : ISeeder
    {
        public async Task SeedAsync(GolfTourDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Players.Any())
            {
                return;
            }

            var players = new List<Player>
            {
                new Player
                {
                    FirstName = "Tiger",
                    LastName = "Woods",
                    ImagePlayer = " ",
                    Country = "USA",
                    City = "Orlando",
                },
                new Player
                {
                    FirstName = "Rory",
                    LastName = "McIlroy",
                    ImagePlayer = " ",
                    Country = "Ireland",
                    City = "Belfast",
                },
                new Player
                {
                    FirstName = "Phil",
                    LastName = "Mickelson",
                    ImagePlayer = " ",
                    Country = "USA",
                    City = "San Diego",
                },
                new Player
                {
                    FirstName = "Jordan",
                    LastName = "Spieth",
                    ImagePlayer = " ",
                    Country = "USA",
                    City = "Dallas",
                },
                new Player
                {
                    FirstName = "Justin",
                    LastName = "Thomas",
                    ImagePlayer = " ",
                    Country = "USA",
                    City = "Louisville",
                },
                new Player
                {
                    FirstName = "Brooks",
                    LastName = "Koepka",
                    ImagePlayer = " ",
                    Country = "USA",
                    City = "Palm Beach",
                },
                new Player
                {
                    FirstName = "Dustin",
                    LastName = "Johnson",
                    ImagePlayer = " ",
                    Country = "USA",
                    City = "Jupiter",
                },
                new Player
                {
                    FirstName = "Rickie",
                    LastName = "Fowler",
                    ImagePlayer = " ",
                    Country = "USA",
                    City = "Jupiter",
                },
                new Player
                {
                    FirstName = "Bryson",
                    LastName = "DeChambeau",
                    ImagePlayer = " ",
                    Country = "USA",
                    City = "Dallas",
                },
                new Player
                {
                    FirstName = "Jon",
                    LastName = "Rahm",
                    ImagePlayer = " ",
                    Country = "Spain",
                    City = "Barcelona",
                },
            };
            foreach (var player in players)
            {
                await dbContext.Players.AddAsync(new Player
                {
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    ImagePlayer = player.ImagePlayer,
                    Country = player.Country,
                    City = player.City,
                });
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
