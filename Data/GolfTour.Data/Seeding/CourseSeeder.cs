namespace GolfTour.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Models;

    public class CourseSeeder : ISeeder
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
                    Name = "Augusta",
                    Country = "USA",
                    City = "Augusta, Georgia",
                    Designer = "Alister MacKenzie, Bobby Jones",
                    ImageCourse = " ",
                },
                new Course
                {
                    Name = "Pebble Beach",
                    Country = "USA",
                    City = "Pebble Beach, California",
                    Designer = "Jack Neville, Douglas Grant",
                    ImageCourse = " ",
                },
                new Course
                {
                    Name = "St. Andrews",
                    Country = "Scotland",
                    City = "St. Andrews",
                    Designer = "Old Tom Morris",
                    ImageCourse = " ",
                },
                new Course
                {
                    Name = "Royal County",
                    Country = "Ireland",
                    City = "Newcastle",
                    Designer = "Old Tom Morris",
                    ImageCourse = " ",
                },
                new Course
                {
                    Name = "Cypress Point",
                    Country = "USA",
                    City = "Pebble Beach, California",
                    Designer = "Alister MacKenzie",
                    ImageCourse = " ",
                },
                new Course
                {
                    Name = "Royal Melbourne",
                    Country = "Australia",
                    City = "Melbourne",
                    Designer = "Alister MacKenzie",
                    ImageCourse = " ",
                },
                new Course
                {
                    Name = "Muirfield",
                    Country = "Scotland",
                    City = "Gullane",
                    Designer = "Old Tom Morris",
                    ImageCourse = " ",
                },
                new Course
                {
                    Name = "Hills",
                    Country = "USA",
                    City = "Southampton, New York",
                    Designer = "William Flynn",
                    ImageCourse = " ",
                },
                new Course
                {
                    Name = "Sand Hills",
                    Country = "USA",
                    City = "Mullen, Nebraska",
                    Designer = "Bill Coore, Ben Crenshaw",
                    ImageCourse = " ",
                },
                new Course
                {
                    Name = "Royal Portrush",
                    Country = "Ireland",
                    City = "Portrush",
                    Designer = "Harry Colt",
                    ImageCourse = " ",
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

            await dbContext.SaveChangesAsync();
         }
     }
}
