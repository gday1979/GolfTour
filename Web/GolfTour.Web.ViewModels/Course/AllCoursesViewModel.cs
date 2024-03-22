namespace GolfTour.Web.ViewModels.Course
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Models;

    using static GolfTour.Web.ViewModels.ViewModelsValidations.Course;

    public class AllCoursesViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string ImageCourse { get; set; }

        public string Designer { get; set; }

        public virtual IEnumerable<Course> Courses { get; set; }
    }
}
