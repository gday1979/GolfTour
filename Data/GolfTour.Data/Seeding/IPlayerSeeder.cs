namespace GolfTour.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Models;

    public class IPlayerSeeder : ISeeder
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
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-tiger-woods-masters-2019-getty.jpg",
                    Country = "USA",
                    City = "Orlando",
                },
                new Player
                {
                    FirstName = "Rory",
                    LastName = "McIlroy",
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-rory-mcilroy-masters-2019-getty.jpg",
                    Country = "Northern Ireland",
                    City = "Belfast",
                },
                new Player
                {
                    FirstName = "Phil",
                    LastName = "Mickelson",
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-phil-mickelson-masters-2019-getty.jpg",
                    Country = "USA",
                    City = "San Diego",
                },
                new Player
                {
                    FirstName = "Jordan",
                    LastName = "Spieth",
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-jordan-spieth-masters-2019-getty.jpg",
                    Country = "USA",
                    City = "Dallas",
                },
                new Player
                {
                    FirstName = "Justin",
                    LastName = "Thomas",
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-justin-thomas-masters-2019-getty.jpg",
                    Country = "USA",
                    City = "Louisville",
                },
                new Player
                {
                    FirstName = "Brooks",
                    LastName = "Koepka",
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-brooks-koepka-masters-2019-getty.jpg",
                    Country = "USA",
                    City = "West Palm Beach",
                },
                new Player
                {
                    FirstName = "Dustin",
                    LastName = "Johnson",
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-dustin-johnson-masters-2019-getty.jpg",
                    Country = "USA",
                    City = "Jupiter",
                },
                new Player
                {
                    FirstName = "Rickie",
                    LastName = "Fowler",
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-rickie-fowler-masters-2019-getty.jpg",
                    Country = "USA",
                    City = "Jupiter",
                },
                new Player
                {
                    FirstName = "Bryson",
                    LastName = "DeChambeau",
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-bryson-dechambeau-masters-2019-getty.jpg",
                    Country = "USA",
                    City = "Dallas",
                },
                new Player
                {
                    FirstName = "Jon",
                    LastName = "Rahm",
                    ImagePlayer = "https://www.golfdigest.com/content/dam/images/golfdigest/fullset/2019/4/15/1/20190415-jon-rahm-masters-2019-getty.jpg",
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
        }
    }
}
