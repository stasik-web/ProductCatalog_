using Microsoft.AspNetCore.Mvc;

namespace ProductCatalog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Каталог веб-қосымшасына қош келдіңіз!";
            return View();
        }
    }
}
