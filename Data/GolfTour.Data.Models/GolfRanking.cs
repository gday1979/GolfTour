namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    public class GolfRanking : BaseDeletableModel<int>
    {
        public GolfRanking()
        {
            this.Players = new HashSet<Player>();
            this.Tours = new HashSet<Tour>();
            this.FedexCups = new HashSet<FedexCup>();
        }

        [Required]
        public string Player { get; set; }

        public decimal Points { get; set; }

        [Required]
        public int MoneyPrize { get; set; }

        [Required]
        public int TournamentsPlayed { get; set; }

        [Required]
        public int Wins { get; set; }

        [Required]
        public int MoneyRanking { get; set; }

        [Required]
        public int ScoringRanking { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

        public virtual ICollection<FedexCup> FedexCups { get; set; }
    }
}
