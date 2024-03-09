namespace GolfTour.Web.ViewModels.Tour
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class TourViewModel
    {
        public string Name { get; set; }

        public string ImageTour { get; set; }

        public string Description { get; set; }

        [Required]
        [DisplayName("Start Date")]
        []
        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string CourseName { get; set; }

        public string CourseImage { get; set; }

        public string CourseDesigner { get; set; }

        public string CourseCountry { get; set; }

        public string CourseCity { get; set; }

        public string CourseFedexCupId { get; set; }

        public string CoursePgaTourId { get; set; }

        public string CourseTourId { get; set; }

        public string CourseRankingId { get; set; }
    }
}