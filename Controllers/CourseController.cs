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
            kurs.Image = "course1.jpg";
            return View(kurs);
        }

        public IActionResult List()
        {
            var kurslar = new List<Course>()
            {
                new Course() { Id = 1, Title ="aspnet kursu", Description =" guzel kurs",Image ="course1.jpg"},
                new Course() { Id = 2, Title ="php kursu", Description =" guzel kurs",Image ="course2.jpg"},
                new Course() { Id = 3, Title ="java kursu", Description =" guzel kurs",Image ="course3.jpeg"}
            };

            return View("CourseList", kurslar);
        }
    }
}
