namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    public class Course : BaseDeletableModel<int>
    {
        public Course()
        {
            this.Players = new HashSet<Player>();
            this.FedexCups = new HashSet<FedexCup>();
            this.Tours = new HashSet<Tour>();
        }

        public string Name { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Image { get; set; }

        public int Holes { get; set; }

        public int Par { get; set; }

        public int Length { get; set; }

        public string Designer { get; set; }

        public string YearBuilt { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<FedexCup> FedexCups { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
