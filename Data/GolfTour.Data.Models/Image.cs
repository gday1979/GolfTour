namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Data.Common.Models;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public string Extension { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string RemoteImageUrl { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }



    }
}
