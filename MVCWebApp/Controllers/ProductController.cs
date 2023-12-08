using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MVCWebApp.Data;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductController(ApplicationDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        [ResponseCache(Duration = 180, Location = ResponseCacheLocation.Any)]
        public IActionResult Index()
        {
            var products = _dbContext.Products.ToList();

            var model = new ProductIndexVM { Products = products };

            _dbContext.SaveChanges();

            return View(model);
        }
    }
}
