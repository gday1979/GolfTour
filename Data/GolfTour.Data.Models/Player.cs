﻿namespace GolfTour.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using GolfTour.Data.Common.Models;

    using static GolfTour.Data.Models.DataConstants.Player;

    public class Player : BaseDeletableModel<int>
    {
        public Player()
        {
            this.FedexCups = new HashSet<FedexCup>();
            this.Tours = new HashSet<Tour>();
            this.Courses = new HashSet<Course>();
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
        [StringLength(PlayerAgeMaxValue)]
        public int Age { get; set; }

        [Required]
        public int YearsPro { get; set; }

        [Required]
        public string Image { get; set; }

        public virtual ICollection<FedexCup> FedexCups { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
