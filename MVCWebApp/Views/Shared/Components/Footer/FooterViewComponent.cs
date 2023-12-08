using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCWebApp.Data;
using MVCWebApp.Entities;
using MVCWebApp.Models;

namespace MVCWebApp.Views.Shared.Component.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _dbContext;
        public FooterViewComponent(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IViewComponentResult Invoke()
        {
            var company = _dbContext.CompanyProperties.ToList();

            var model = new CompanyPropertiesVM { companyProperties = company };

            return View(model);
        }
    }
}
