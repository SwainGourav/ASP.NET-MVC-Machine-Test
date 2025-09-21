using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC_Machine_Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
        {
            return Content("Application is working! Go to /product to see products.");
        }
    }
}