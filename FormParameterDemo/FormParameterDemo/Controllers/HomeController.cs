using FormParameterDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormParameterDemo.Controllers
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

        public IActionResult MyForm()
        {
            return View(); 
        }

        public IActionResult ShowData(string nm, string gen, string age)
        {// sequence same rehna chahiye agar data int mein ho tab bhi usko string mein lena hai
         // and baad mein usko typecast kr skte hai 
            ViewBag.Name = nm;
            ViewBag.Gender = gen;
            ViewBag.Age = age;
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
