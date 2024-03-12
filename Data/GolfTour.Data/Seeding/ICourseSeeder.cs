namespace GolfTour.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Models;

    public class ICourseSeeder : ISeeder
    {
        public async Task SeedAsync(GolfTourDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Courses.Any())
            {
                return;
            }

            var courses = new List<Course>
            {
                new Course
                {
                    Name = "Augusta National",
                    Country = "USA",
                    City = "Augusta, Georgia",
                    Designer = "Alister MacKenzie, Bobby Jones",
                    ImageCourse = "https://www.golfdigest.com/story/augusta-national-clubhouse-photos",
                },
                new Course
                {
                    Name = "Pebble Beach",
                    Country = "USA",
                    City = "Pebble Beach, California",
                    Designer = "Jack Neville, Douglas Grant",
                    ImageCourse = "https://www.golfdigest.com/story/pebble-beach-golf-links-photos",
                },
                new Course
                {
                    Name = "St. Andrews",
                    Country = "Scotland",
                    City = "St. Andrews",
                    Designer = "Old Tom Morris",
                    ImageCourse = "https://www.golfdigest.com/story/old-course-photos",
                },
                new Course
                {
                    Name = "Royal County Down",
                    Country = "Northern Ireland",
                    City = "Newcastle",
                    Designer = "Old Tom Morris",
                    ImageCourse = "https://www.golfdigest.com/story/royal-county-down-photos",
                },
                new Course
                {
                    Name = "Cypress Point",
                    Country = "USA",
                    City = "Pebble Beach, California",
                    Designer = "Alister MacKenzie",
                    ImageCourse = "https://www.golfdigest.com/story/cypress-point-club-photos",
                },
                new Course
                {
                    Name = "Royal Melbourne",
                    Country = "Australia",
                    City = "Melbourne",
                    Designer = "Alister MacKenzie",
                    ImageCourse = "https://www.golfdigest.com/story/royal-melbourne-photos",
                },
                new Course
                {
                    Name = "Muirfield",
                    Country = "Scotland",
                    City = "Gullane",
                    Designer = "Old Tom Morris",
                    ImageCourse = "https://www.golfdigest.com/story/muirfield-photos",
                },
                new Course
                {
                    Name = "Shinnecock Hills",
                    Country = "USA",
                    City = "Southampton, New York",
                    Designer = "William Flynn",
                    ImageCourse = "https://www.golfdigest.com/story/shinnecock-hills-photos",
                },
                new Course
                {
                    Name = "Sand Hills",
                    Country = "USA",
                    City = "Mullen, Nebraska",
                    Designer = "Bill Coore, Ben Crenshaw",
                    ImageCourse = "https://www.golfdigest.com/story/sand-hills-photos",
                },
                new Course
                {
                    Name = "Royal Portrush",
                    Country = "Northern Ireland",
                    City = "Portrush",
                    Designer = "Harry Colt",
                    ImageCourse = "https://www.golfdigest.com/story/royal-portrush-photos",
                },
            };
            foreach (var course in courses)
            {
                await dbContext.Courses.AddAsync(new Course
                {
                     Name = course.Name,
                     Country = course.Country,
                     City = course.City,
                     Designer = course.Designer,
                     ImageCourse = course.ImageCourse,
                });
            }
         }
     }
}
