using FirstWebAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppMVC.Controllers
{
    public class StudentDataController : Controller
    {
        static List<Student> students = new List<Student>();
        
        static StudentDataController()
        {
            students.Add
        }

        public IActionResult Index()
        {

            return View(students);
        }

        public IActionResult Details(string id)
        {
            Student s = students.Find(s => s.Studname == id);
            return View(s);
        }
    }
}
