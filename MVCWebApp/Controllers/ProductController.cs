using McvWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var model = new ProductIndexViewModel
            {
                Products = ProductRepository.GetProducts()
            };
            return View(model);
        }
    }
}
