using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class TestimonialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
