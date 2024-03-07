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

    public class PlayerQualified : BaseDeletableModel<int>
    {
        public int PlayerId { get; set; }

        [Required]
        [ForeignKey("PlayerId")]
        public virtual Player Player { get; set; }

        [Required]
        [ForeignKey("TourId")]
        public int TourId { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
