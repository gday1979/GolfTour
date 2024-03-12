namespace GolfTour.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using GolfTour.Data.Models;
    using GolfTour.Web.ViewModels.Course;

    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetAllCourses();

        CourseViewModel GetCourseById(int id);

        void CreateCourse(CourseViewModel course);

        void UpdateCourse(CourseViewModel course);

        void DeleteCourse(int id);
    }
}
