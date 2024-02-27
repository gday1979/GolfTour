﻿namespace GolfTour.Data.Models
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
    }
}
