﻿namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    public class FedexCup : BaseDeletableModel<int>
    {
        public FedexCup()
        {
            this.Players = new HashSet<Player>();
            this.Courses = new HashSet<Course>();
            this.Tours = new HashSet<Tour>();
        }

        [Required]
        public string Player { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Image { get; set; }

        public decimal Points { get; set; }

        public int MoneyPrize { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
