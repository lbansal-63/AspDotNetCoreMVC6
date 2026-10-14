using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewDataDemo.Models;

namespace ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["prodId"] = 1;
            ViewData["prodName"] = "Intel i5 CPU";
            ViewData["prodPrice"] = 15000;
            ViewData["prodQty"] = 20; 
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
