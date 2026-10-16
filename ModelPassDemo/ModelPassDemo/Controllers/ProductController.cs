using Microsoft.AspNetCore.Mvc;
using ModelPassDemo.Models; 

namespace ModelPassDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowData(Product prod)
        {
            ViewBag.Id = prod.prodId;
            ViewBag.Name = prod.prodName;
            ViewBag.Qty = prod.prodqty;
            ViewBag.Price = prod.prodPrice; 

            return View();
        }
    }
}
