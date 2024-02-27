namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class YearCalendar
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Tour { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Courses { get; set; }

        public int MoneyPrize { get; set; }

        public string Player { get; set; }

        public int Points { get; set; }
    }
}
