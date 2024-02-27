namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    public class Tour : BaseDeletableModel<int>
    {
        public Tour()
        {
            
        }

        public string Name { get; set; }

        public string TypeTour { get; set; }

        public string Courses { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public int MoneyPrize { get; set; }

        public string Player { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Points { get; set; }

        public virtual ICollelction<TypeTour> TypeTours { get; set; }

        public virtual ICollelction<Course> Courses { get; set; }


    }
}
