namespace GolfTour.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Services.Data.Contracts;
    using GolfTour.Web.ViewModels.Course;

    public class Course : ICourseService
    {
        public void CreateCourse(CourseViewModel course)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CourseViewModel> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public CourseViewModel GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(CourseViewModel course)
        {
            throw new NotImplementedException();
        }
    }
}
