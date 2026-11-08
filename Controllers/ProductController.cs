using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Ноутбук Lenovo IdeaPad", Price = 285000m, Category = "Электроника", IsAvailable = true },
                new Product { Id = 2, Name = "Смартфон Samsung Galaxy", Price = 320000m, Category = "Электроника", IsAvailable = true },
                new Product { Id = 3, Name = "Наушники Sony WH-1000XM5", Price = 150000m, Category = "Аксессуарлар", IsAvailable = false },
                new Product { Id = 4, Name = "Механическая клавиатура", Price = 45000m, Category = "Аксессуарлар", IsAvailable = true },
                new Product { Id = 5, Name = "Рюкзак для ноутбука", Price = 18000m, Category = "Одежда и сумки", IsAvailable = true },
                new Product { Id = 6, Name = "Монитор 27\" IPS", Price = 130000m, Category = "Электроника", IsAvailable = false }
            };

            ViewBag.TotalCount = products.Count;
            ViewBag.AvailableCount = products.Count(p => p.IsAvailable);

            return View(products);
        }
    }
}
