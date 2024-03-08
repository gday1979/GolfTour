namespace GolfTour.Web.ViewModels.Course
{
    using System.ComponentModel.DataAnnotations;

    public class CourseViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string ImageCourse { get; set; }

        [Required]
        public string Designer { get; set; }
    }
}
