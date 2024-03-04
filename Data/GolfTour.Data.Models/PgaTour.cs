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
        }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("PlayerQualified")]
        public int PlayerQualifiedId { get; set; }

        public PlayerQualified PlayerQualified { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string ImageTour { get; set; }

        public string Designer { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
