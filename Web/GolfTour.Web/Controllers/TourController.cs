namespace GolfTour.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class TourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
