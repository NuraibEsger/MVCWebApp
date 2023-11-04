using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
