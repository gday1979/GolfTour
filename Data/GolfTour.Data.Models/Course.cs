namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    using static GolfTour.Data.Models.DataConstants.Course;

    public class Course : BaseDeletableModel<int>
    {
        public Course()
        {
            this.Players = new HashSet<Player>();
            this.Images = new HashSet<Image>();
        }

        [Required]
        [StringLength(CourseCityMaxLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(CourseCountryMaxLength)]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string ImageCourse { get; set; }

        [Required]
        public string Designer { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public string AddedByUserId { get; set; }
    }
}
