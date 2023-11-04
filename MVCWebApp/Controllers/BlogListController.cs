using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp.Controllers
{
    public class BlogListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
