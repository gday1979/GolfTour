namespace GolfTour.Services.Data.Course
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using GolfTour.Data.Models;
    using GolfTour.Web.ViewModels.Course;

    public interface ICourseService
    {
        Task<int> GetAllCoursesCountAsync();

        Task<int> CreateCourseAsync(CourseViewModel input, string userId);

        Task<int> EditCourseAsync(CourseViewModel input, string userId);

        Task<TViewModel> GetCourseDetailsAsync<TViewModel>(int courseId); 
    }
}
