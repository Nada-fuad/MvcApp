using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Areas.LandingPages.Controllers
{
    public class HomeController : Controller
    {
        [Area("LandingPages")]
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
