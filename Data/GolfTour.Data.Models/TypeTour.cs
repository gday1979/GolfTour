namespace GolfTour.Data.Models
{
    using System.Collections.Generic;

    public class TypeTour
    {
        public TypeTour()
        {
            this.Tours = new HashSet<Tour>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
