using Microsoft.AspNetCore.Mvc;
using RequestObjectDemo.Models;
using System.Diagnostics;

namespace RequestObjectDemo.Controllers
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
        public IActionResult ShowData()
        {
            ViewBag.sid = Request.Form["sid"];
            ViewBag.snm = Request.Form["snm"];
            ViewBag.dob = Request.Form["sdob"];
            ViewBag.gen = Request.Form["sgen"];
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
