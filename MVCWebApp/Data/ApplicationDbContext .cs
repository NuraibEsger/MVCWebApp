using Microsoft.EntityFrameworkCore;
using MVCWebApp.Entites;
using MVCWebApp.Entities;

namespace MVCWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<CompanyProperties> CompanyProperties { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<TestimonialProperty> TestimonialProperties { get; set; }
    }

}
