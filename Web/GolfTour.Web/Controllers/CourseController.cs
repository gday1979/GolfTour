namespace GolfTour.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using GolfTour.Data;
    using GolfTour.Data.Models;
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
           List<Course> courses = this.context.Courses.ToList();
           return this.View(courses);
        }
    }
}
