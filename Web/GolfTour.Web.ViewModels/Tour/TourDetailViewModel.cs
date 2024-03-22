namespace GolfTour.Web.ViewModels.Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTour.Services.Mapping;

    using Tour = GolfTour.Data.Models.Tour;

    public class TourDetailViewModel : IMapFrom<Tour>
    {
    }
}
