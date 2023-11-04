using Microsoft.AspNetCore.Mvc;

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
