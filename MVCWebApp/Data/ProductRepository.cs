using MVCWebApp.Entites;
namespace McvWebApp.Data
{
    public class ProductRepository
    {
        private static List<Product> products = new()
        {
            new(){Id =1, Name = "Men's shirt", Price = 75, ImagePath = "p1.png"},
            new(){Id =2, Name = "Men's shirt", Price = 80, ImagePath = "p2.png"},
            new(){Id =3, Name = "Women's shirt", Price = 68, ImagePath = "p3.png"},
            new(){Id =4, Name = "Women's shirt", Price = 70, ImagePath = "p4.png"},
            new(){Id =5, Name = "Women's shirt", Price = 75, ImagePath = "p5.png"},
            new(){Id =6, Name = "Women's shirt", Price = 58, ImagePath = "p6.png"},
            new(){Id =7, Name = "Women's shirt", Price = 80, ImagePath = "p7.png"},
            new(){Id =8, Name = "Men's shirt", Price = 65, ImagePath = "p8.png"},
            new(){Id =9, Name = "Men's shirt", Price = 65, ImagePath = "p9.png"},
            new(){Id =10, Name = "Men's shirt", Price = 65, ImagePath = "p10.png"},
            new(){Id =11, Name = "Men's shirt", Price = 65, ImagePath = "p11.png"},
            new(){Id =12, Name = "Women's shirt", Price = 65, ImagePath = "p12.png"}
        };

        public static List<Product> GetProducts() { return products; }
    }
}
