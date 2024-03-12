namespace GolfTour.Web.ViewModels.Player
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public class PlayerFormModel
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Country { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string City { get; set; }

        [Required]
        [Range(1, 30)]
        public int YearsPro { get; set; }

        [Required]
        [Display(Name = "Image")]
        public IFormFile ImagePlayer { get; set; }
    }
}
