namespace GolfTour.Services.Data.Course
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using GolfTour.Web.ViewModels.Course;

    public class CourseService : ICourseService
    {
        private readonly ICourseService courseService;

        public CourseService()
        {
        }

        public async Task<int> CreateCourseAsync(CourseViewModel input, string userId)
        {
            var course = new CourseViewModel
            {
                Name = input.Name,
                Country = input.Country,
                City = input.City,
                Designer = input.Designer,
                ImageCourse = input.ImageCourse,
            };
            await this.courseService.CreateCourseAsync(course, userId);
            return 1;
        }

        public Task<int> EditCourseAsync(CourseViewModel input, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CourseViewModel>> GetAllCoursesAsync(int courseId, int take, int skip)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountAllCourses(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetDetails<T>(CourseViewModel input)
        {
            throw new NotImplementedException();
        }
    }
}
