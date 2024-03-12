namespace GolfTour.Web.ViewModels.Tour
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class TourViewModel
    {
        public string Name { get; set; }

        public IFormFile ImageTour { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        [DisplayName("Start Date")]
        public string StartDate { get; set; }

        [Required]
        [DisplayName("End Date")]
        public string EndDate { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string City { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string CourseName { get; set; }

        public IFormFile CourseImage { get; set; }
    }
}