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

    public class PgaTour : BaseDeletableModel<int>
    {
        public PgaTour()
        {
            this.Courses = new HashSet<Course>();
            this.Players = new HashSet<Player>();
            this.PlayerQualifieds = new HashSet<PlayerQualified>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("PlayerQualified")]
        public int PlayerQualifiedId { get; set; }

        public PlayerQualified PlayerQualified { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string ImageTour { get; set; }

        [Required]
        public string Designer { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<PlayerQualified> PlayerQualifieds { get; set; }


    }
}
