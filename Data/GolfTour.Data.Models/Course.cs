namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Image { get; set; }

        public int Holes { get; set; }

        public int Par { get; set; }

        public int Length { get; set; }

        public string Designer { get; set; }

        public string YearBuilt { get; set; }

    }
}
