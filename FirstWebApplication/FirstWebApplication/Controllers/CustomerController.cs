using BusinessLogicLibrary;
using FirstWebAppMVC.Models;
using HelperLibrary;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppMVC.Controllers
{
    public class CustomerController : Controller
    {
        CustomerHelper helper = new CustomerHelper();
        public IActionResult NewCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewCustomer(CustomerViewModel model)
        {
            CustomerBAL bal = new CustomerBAL();

            bal.CustomerId = model.CustomerId;
            bal.CustName = model.CustName;

            helper.InsertCustomer(bal);

            return RedirectToAction("Index"); // To know record inserted or not return -->in index action show list of customer is there
            
            //return Content("Record Inserted SuccessFully");
        }
        public IActionResult Index()
        {
            //Show list of Customer
            List<CustomerBAL> custlist = helper.GetCustomers();
            List<CustomerViewModel> modellist = new List<CustomerViewModel>();
            foreach (var cust in custlist)
            {
                CustomerViewModel model = new CustomerViewModel();
                model.CustomerId = cust.CustomerId; 
                model.CustName = cust.CustName;
                modellist.Add(model);
            }
            return View(modellist);
        }
        public IActionResult EditCustomer(int id)
        {
            CustomerBAL bal = helper.FindCustomer(id);
            CustomerViewModel model = new CustomerViewModel();
            model.CustomerId = bal.CustomerId;
            model.CustName= bal.CustName;
            return View(model);
        }



       [HttpPost]
        public IActionResult EditCustomer(int id , CustomerViewModel model)
        {
            CustomerBAL bal = new CustomerBAL();
            bal.CustomerId = model.CustomerId;
            bal.CustName= model.CustName;
            helper.UpdateCustomer(id, bal);
            return RedirectToAction("Index");
        }

        public IActionResult CustomerDetails(int id)
        {
            CustomerBAL bal = helper.FindCustomer(id);
            CustomerViewModel model = new CustomerViewModel();
            model.CustomerId = bal.CustomerId;
            model.CustName = bal.CustName;
            return View(model);
        }
        public IActionResult DeleteCustomer(int id)
        {
            CustomerBAL bal = helper.FindCustomer(id);
            CustomerViewModel model = new CustomerViewModel();
            model.CustomerId = bal.CustomerId;
            model.CustName = bal.CustName;
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteCustomer(int id, CustomerViewModel model)
        {
            helper.DeleteCustomer(id);
            return RedirectToAction("Index");
        }
    }
}
