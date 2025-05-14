using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
