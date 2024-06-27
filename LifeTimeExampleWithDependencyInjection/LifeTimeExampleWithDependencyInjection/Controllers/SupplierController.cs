using LifeTimeExampleWithDependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace LifeTimeExampleWithDependencyInjection.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _repository;

        public SupplierController(ISupplierRepository repository) 
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            List<SupplierViewModel> supplierList = _repository.GetSuppliers();
            return View(supplierList);
        }

        public IActionResult Details(int id)
        {
            SupplierViewModel model = _repository.FindSupplier(id);
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            SupplierViewModel supplier = _repository.FindSupplier(id);
            return View(supplier);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _repository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View();
            }
           
        }

        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                SupplierViewModel viewModel = new SupplierViewModel();
                viewModel.SuppId = Convert.ToInt32(collection["SuppId"]);
                viewModel.SuppName = collection["SuppName"];
                viewModel.City = collection["City"];
                _repository.Insert(viewModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }  
        }

        public ActionResult Edit(int id)
        {
            SupplierViewModel model = _repository.FindSupplier(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id ,  IFormCollection collection)
        {
            try
            {
                SupplierViewModel viewModel = new SupplierViewModel();
                viewModel.SuppId = Convert.ToInt32(collection["suppId"]);
                viewModel.SuppName = collection["suppName"];
                viewModel.City = collection["City"];
                _repository.Update(id,viewModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
