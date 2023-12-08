using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCWebApp.Data;
using MVCWebApp.Models;
using System.Diagnostics;

namespace MVCWebApp.Controllers
{
    public class HomeController : Controller
    {
		private readonly ApplicationDbContext _dbContext;
        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
		}

        [ResponseCache(Duration = 180, Location = ResponseCacheLocation.Any)]
        public IActionResult Index()
        {
            var products = _dbContext.Products.ToList();
            var model = new HomeIndexVM()
            {
                Products = products
            };

            _dbContext.SaveChanges();

            return View(model);
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