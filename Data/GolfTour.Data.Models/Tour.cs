namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    public class Tour : BaseDeletableModel<int>
    {
        public Tour()
        {
            this.Players = new HashSet<Player>();

            this.FedexCups = new HashSet<FedexCup>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string TypeTour { get; set; }

        [Required]
        public string Courses { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int MoneyPrize { get; set; }

        [Required]
        public string Player { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Points { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<FedexCup> FedexCups { get; set; }
    }
}
