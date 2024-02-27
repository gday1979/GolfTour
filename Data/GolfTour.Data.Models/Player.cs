namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player
    {
        public string FirstName{ get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public int Age { get; set; }

        public int YearsPro { get; set; }

        public string Image { get; set; }

        public string Bio { get; set; }

        public virtual ICollection<FedexCup> FedexCups { get; set; }

        public virtual ICollection<YearCalendar> YearCalendars { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

        public virtual ICollection<Course> Courses { get; set; }


    }
}
