namespace GolfTour.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using GolfTour.Data;
    using GolfTour.Data.Common.Repositories;
    using GolfTour.Data.Models;
    using GolfTour.Web.ViewModels.Course;
    using Microsoft.AspNetCore.Mvc;

    public class CourseController : Controller
    {
        private readonly GolfTourDbContext context;

        public CourseController(GolfTourDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var course = await this.context.Courses.FindAsync(id);
            if (course == null)
            {
                return this.NotFound();
            }

            var courseView = new DetailsViewModel
            {
                Name = course.Name,
                Country = course.Country,
                City = course.City,
                Designer = course.Designer,
                ImageCourse = course.ImageCourse,
            };
            return View(courseView);
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var courseToAdd = new Course
            {
                Name = course.Name,
                Designer = course.Designer,
                Country = course.Country,
                City = course.City,
            };
            this.context.Courses.Add(courseToAdd);
            this.context.SaveChanges();

            return this.RedirectToAction("/");
        }
    }
}
