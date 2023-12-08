using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Data;
using MVCWebApp.Models;

namespace MVCWebApp.Views.Shared.Components.TestimonialProperty
{
    public class TestimonialPropertyViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext? _dbContext;
        public TestimonialPropertyViewComponent(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var testimonialProperties = _dbContext.TestimonialProperties.ToList();

            var model = new TestimonialVM()
            {
                TestimonialProperties = testimonialProperties
            };

            _dbContext.SaveChanges();

            return View(model);
        }
    }
}
