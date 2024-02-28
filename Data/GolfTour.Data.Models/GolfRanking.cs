namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
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

        public string Player { get; set; }

        public int Points { get; set; }

        public int MoneyPrize { get; set; }

        public int TournamentsPlayed { get; set; }

        public int Wins { get; set; }

        public int MoneyRanking { get; set; }

        public int ScoringRanking { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

        public virtual ICollection<FedexCup> FedexCups { get; set; }
    }
}
