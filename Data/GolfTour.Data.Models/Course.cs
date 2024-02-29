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
            this.FedexCups = new HashSet<FedexCup>();
            this.Tours = new HashSet<Tour>();
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
        public string Image { get; set; }

        [Required]
        [StringLength(CourseHolesMaxValue)]
        public int Holes { get; set; }

        [Required]
        public int Par { get; set; }

        [Required]
        public int Length { get; set; }

        [Required]
        public string Designer { get; set; }

        [Required]
        public int YearBuilt { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<FedexCup> FedexCups { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
