namespace GolfTour.Web.ViewModels.Course
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AllCoursesViewModel
    {
        public IEnumerable<CourseViewModel> Courses { get; set; }
    }
}
