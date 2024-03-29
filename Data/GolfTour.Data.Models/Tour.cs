﻿namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    public class Tour : BaseDeletableModel<int>
    {
        public Tour()
        {
            this.Players = new HashSet<Player>();
            this.Courses = new HashSet<Course>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("TypeTour")]
        public int TypeTourId { get; set; }

        [Required]
        public TypeTour TypeTour { get; set; }

        [Required]
        public string City { get; set; }

        public int PrizeMoney { get; set; }

        public int Points { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
