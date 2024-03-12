namespace GolfTour.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using GolfTour.Data;
    using GolfTour.Data.Common.Repositories;
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
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return this.RedirectToAction("/");
        }
    }
}
