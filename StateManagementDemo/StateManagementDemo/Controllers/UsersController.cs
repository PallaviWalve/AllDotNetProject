using Microsoft.AspNetCore.Mvc;
using StateManagementDemo.Models;

namespace StateManagementDemo.Controllers
{
    public class UsersController : Controller
    {
        static List<UserViewModel> userslist = new List<UserViewModel>()
        {
            new UserViewModel{UserName = "Chetana",Password = "Chetana@123"},
            new UserViewModel{UserName = "Shreya",Password = "Shreya@123"},
            new UserViewModel{UserName = "Shrushti",Password = "Shrushti@123"}
        };
        public IActionResult Index()
        {
            ViewBag.username = "Pallavi";
            ViewBag.usersData = userslist;

            ViewData["newname"] = "Druva";
            ViewData["newUserList"] = userslist;
            return View();
        }

       
        public ActionResult SendData()
        {
            TempData["v1"] = "Greetings";
            TempData.Put("LoggedUsers",userslist);

            return RedirectToAction("ReceiveData");
        }

        public ActionResult ReceiveData()
        {
            string s = TempData["v1"].ToString();
            ViewBag.receivedData = s;
            List<UserViewModel> newlist = new List<UserViewModel>();
            newlist = (List<UserViewModel>)TempData.Get<List<UserViewModel>>("LoggedUsers");
          
            //TempData["gettingData"] = newlist;
            return View(newlist);
        }

    }
}
