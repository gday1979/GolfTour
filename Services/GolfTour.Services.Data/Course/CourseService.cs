namespace GolfTour.Services.Data.Course
{
    using System;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Repositories;
    using GolfTour.Data.Models;
    using GolfTour.Web.ViewModels.Course;

    public class CourseService : ICourseService
    {
        private readonly IDeletableEntityRepository<Course> courseRepository;

        public CourseService(IDeletableEntityRepository<Course> courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public async Task<int> CreateCourseAsync(CourseViewModel input, string userId)
        {
            var course = new Course
            {
                Name = input.Name,
                Country = input.Country,
                City = input.City,
                Designer = input.Designer,
                ImageCourse = input.ImageUrl,
                AddedByUserId = userId,
            };
            await this.courseRepository.AddAsync(course);
            await this.courseRepository.SaveChangesAsync();
            return course.Id;

        }

        public Task<int> EditCourseAsync(CourseViewModel input, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetAllCoursesCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TViewModel> GetCourseDetailsAsync<TViewModel>(int courseId)
        {
            throw new NotImplementedException();
        }
    }
}
