using Microsoft.AspNetCore.Mvc;

namespace LifeTimeExampleWithDependencyInjection.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("RollNo", 11);
            HttpContext.Session.SetString("StudentName", "Pallavi");

          /*  ViewBag.RollNo = HttpContext.Session.GetInt32("RollNo");
            ViewBag.Sname = HttpContext.Session.GetString("StudentName");*/
            
            return RedirectToAction("ShowValues");
        }

        public ActionResult ShowValues()
        {
            ViewBag.RollNo = HttpContext.Session.GetInt32("RollNo");
            ViewBag.Sname = HttpContext.Session.GetString("StudentName");

            return View();
        }

        public ActionResult SomeAction()
        {
            ViewBag.value1 = "Hello";
            return View();
        }

        public ActionResult Greetings()
        {
            ViewBag.value1 = "Good Day";
            return View();
        }
    }
}
 