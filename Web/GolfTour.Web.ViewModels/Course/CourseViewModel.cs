namespace GolfTour.Web.ViewModels.Course
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
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

        public int FedexCupId { get; set; }

        public int PgaTourId { get; set; }

        public int TourId { get; set; }

        public int RankingId { get; set; }

        public IEnumerable<SelectListItem> SelectListItems { get; set; }

        public IEnumerable<TourViewModel> Tours { get; set; }
    }
}
