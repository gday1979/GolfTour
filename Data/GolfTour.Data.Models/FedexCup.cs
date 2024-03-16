namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    public class FedexCup : BaseDeletableModel<int>
    {
        public FedexCup()
        {
           this.Courses = new HashSet<Course>();
        }

        [Required]
        [ForeignKey("PlayerQualified")]
        public int PlayerQualifiedId { get; set; }

        public PlayerQualified PlayerQualified { get; set; }

        public int Points { get; set; }

        public int PrizeMoney { get; set; }

        public int TournamentsPlayed { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public ICollection<Course> Courses { get; set; }

        public virtual ICollection<PlayerQualified> PlayerQualifieds { get; set; }
    }
}
