namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    public class News : BaseDeletableModel<int>
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

    }
}
