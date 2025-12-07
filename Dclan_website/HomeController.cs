using Microsoft.AspNetCore.Mvc;

namespace Dclan_website
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult blog ()
        {
            return View();
        }
        public IActionResult feature()
        {
            return View();
        }
        public IActionResult pricing()
        {
            return View();
        }
    }
}

