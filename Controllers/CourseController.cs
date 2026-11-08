using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult List()
        {
            var courses = new List<Course>
            {
                new Course { Id = 1, Title = "C# Web Apps", Credits = 5, Instructor = "Проф. Ахметов" },
                new Course { Id = 2, Title = "MS SQL Server", Credits = 4, Instructor = "Доц. Серіков" }
            };
            return View(courses);
        }
    }
}
