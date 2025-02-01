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
            kurs.Description = "Gucel bir kurs";
            return View(kurs);
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
