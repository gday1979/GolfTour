namespace GolfTour.Services.Data.Course
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using GolfTour.Data.Models;
    using GolfTour.Web.ViewModels.Course;

    public interface ICourseService
    {
        Task<CourseEditViewModel> CreateAsync(CourseViewModel courseViewModel);

        Task DeleteByIdAsync(int id);

        Task GetAllCoursesAsync<T>();

        Task<string> GetByIdAsync(int id);

        Task GetViewModelByIdAsync<T>(int id);

        Task UpdateAsync(int id, CourseViewModel courseViewModel);
    }
}
