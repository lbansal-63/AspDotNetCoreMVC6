using FormCollectionDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormCollectionDemo.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult ShowData(IFormCollection data) // show as dictionary format
        {
            ViewBag.sid = data["sid"];
            ViewBag.snm = data["snm"];
            ViewBag.dob = data["sdob"];
            ViewBag.gen = data["sgen"];
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
