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
        }

        [Required]
        public string Player { get; set; }

        public int Points { get; set; }

        [Required]
        public int PrizeMoney { get; set; }

        [Required]
        public int TournamentsPlayed { get; set; }

        [Required]
        public int Wins { get; set; }

        [Required]
        public int MoneyRanking { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
