using System.Diagnostics;
using System.Web.Mvc;
using ExceptionHandlingMVCDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace ExceptionHandlingMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HandleError(ExceptionType = typeof(DivideByZeroException),View ="Error")]
        public IActionResult Index()
        {
            int a = 10;
            int b = 0;
            int c = 0;
            c = a / b;
            ViewBag.result = c;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}