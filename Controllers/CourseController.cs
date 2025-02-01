using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var kurs = new Course();
            kurs.Id = 1;
            kurs.Title = "Aspnet Core Kursu";
            return View(kurs);
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
