namespace GolfTour.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using GolfTour.Data.Common.Models;

    using static GolfTour.Data.Models.DataConstants.Player;

    public class Player : BaseDeletableModel<int>
    {
        public Player()
        {
            this.PlayerQualifieds = new HashSet<PlayerQualified>();
            this.Courses = new HashSet<Course>();
            this.Images = new HashSet<Image>();
        }

        [Required]
        [StringLength(PlayerFirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(PlayerLastNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [StringLength(PlayerCountryMaxLength)]
        public string Country { get; set; }

        [Required]
        [StringLength(PlayerCityMaxLength)]
        public string City { get; set; }

        [Required]
        public int YearsPro { get; set; }

        [Required]
        public string ImagePlayer { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<PlayerQualified> PlayerQualifieds { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
