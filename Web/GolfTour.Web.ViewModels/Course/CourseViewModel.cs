namespace GolfTour.Web.ViewModels.Course
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using GolfTour.Web.ViewModels.Tour;

    using static GolfTour.Web.ViewModels.ViewModelsValidations.Course;

    public class CourseViewModel
    {
        [Required]
        [StringLength(NameCourseMaxLength, MinimumLength = NameCourseMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(CountryMaxLength, MinimumLength =CountryMinLength)]
        public string Country { get; set; }

        [Required]
        [StringLength(CityMaxLength, MinimumLength = CityMinLength)]
        public string City { get; set; }

        [Required]
        public string ImageCourse { get; set; }

        [Required]
        [StringLength(DesignerMaxLength, MinimumLength = DesignerMinLength)]
        public string Designer { get; set; }
    }
}
