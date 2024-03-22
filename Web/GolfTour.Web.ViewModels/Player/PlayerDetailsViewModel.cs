namespace GolfTour.Web.ViewModels.Player
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Services.Mapping;

    using static GolfTour.Web.ViewModels.ViewModelsValidations.Player;

    using Player = GolfTour.Data.Models.Player;

    public class PlayerDetailsViewModel : IMapFrom<Player>
    {
        public int Id { get; set; }

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public string LastName { get; set; }
    }
}
