namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FedexCup
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Image { get; set; }

        public int Points { get; set; }

        public int MoneyPrize { get; set; }

        public string Player { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

        public virtual ICollection<YearCalendar> YearCalendars { get; set; }
    }
}
