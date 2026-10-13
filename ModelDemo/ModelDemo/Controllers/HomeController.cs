using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;
using System.Diagnostics;

namespace ModelDemo.Controllers
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
            Student student = new Student()
            {
                roll = 1,
                name = "Laksha Bansal",
                gender = "Male",
                age = 21,
                course = "Dot Net",
                fee = 7000
            };  
            
            return View(student);
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
