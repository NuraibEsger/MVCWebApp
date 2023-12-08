using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCWebApp.Data;
using MVCWebApp.Entities;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext? _dbContext;

        public ContactController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactIndexVM contactInfo)
        {
            if (!ModelState.IsValid) return View(contactInfo);

            if (_dbContext.ContactInfos.Any(c => c.Email == contactInfo.Email))
            {
                ModelState.AddModelError("Email", "Email already exists");
                return View(contactInfo);
            }

            var contact = new ContactInfo()
            {
                Name = contactInfo.Name,
                Email = contactInfo.Email,
                Subject = contactInfo.Subject,
                Message = contactInfo.Message,
            };

            _dbContext.ContactInfos.Add(contact);

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
