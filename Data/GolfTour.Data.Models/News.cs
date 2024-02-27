namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class News
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public DateTime Date { get; set; }
    }
}
