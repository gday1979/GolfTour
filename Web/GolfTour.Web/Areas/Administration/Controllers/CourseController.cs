namespace GolfTour.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using GolfTour.Services.Data.Course;
    using GolfTour.Web.ViewModels.Course;
    using Microsoft.AspNetCore.Mvc;

    public class CourseController : AdministrationController
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseViewModel courseViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(courseViewModel);
            }

            await this.courseService.CreateAsync(courseViewModel);
            return this.RedirectToAction("GetAllCourses", "Course", new { area = "Administration" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            var course = await this.courseService.GetByIdAsync(id);
            return this.View(course);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CourseViewModel courseViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(courseViewModel);
            }

            await this.courseService.UpdateAsync(id, courseViewModel);
            return this.RedirectToAction("GetAllCourses", "Course", new { area = "Administration" });
        }

        public async Task<IActionResult> Remove(int id)
        {
            var courseToDelete = await this.courseService.GetViewModelByIdAsync<CourseEditViewModel>(id);
            return await this.View(courseToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> Remove(CourseEditViewModel courseDetailsViewModel)
        {
            await this.courseService.DeleteByIdAsync(courseDetailsViewModel.Id);
            return this.RedirectToAction("GetAllCourses", "Course", new { area = "Administration" });
        }

        public async Task<IActionResult> GetAllCourses()
        {
            var courses = await this.courseService.GetAllCoursesAsync<AllCoursesViewModel>();
            return await this.View(courses);
        }
    }
}
