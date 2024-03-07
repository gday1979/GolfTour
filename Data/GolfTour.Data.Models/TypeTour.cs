namespace GolfTour.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using GolfTour.Data.Common.Models;

    public class TypeTour : BaseDeletableModel<int>
    {
        public TypeTour()
        {
            this.Players = new HashSet<Player>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
