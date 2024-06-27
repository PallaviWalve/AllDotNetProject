namespace LifeTimeExampleWithDependencyInjection.Models
{
    public class SupplierRepository : ISupplierRepository
    {
        static List<SupplierViewModel> supplierList = new List<SupplierViewModel>()
        {
            new SupplierViewModel { SuppId = 1,SuppName = "Raksha Enterprises",City = "Pune"},
            new SupplierViewModel { SuppId = 2,SuppName = "Harshita Services",City = "Mumbai"},
            new SupplierViewModel { SuppId = 3,SuppName = "Pari Consultant",City = "Nashik"},
            new SupplierViewModel { SuppId = 4,SuppName = "Deepak Solutions",City = "Pune"}
        };

        public void Delete(int id)
        {
            SupplierViewModel model = supplierList.Find(s => s.SuppId == id);
            supplierList.Remove(model);
        }

        public SupplierViewModel FindSupplier(int id)
        {
            SupplierViewModel model = supplierList.Find(s => s.SuppId == id);
            return model;
        }

        public List<SupplierViewModel> GetSuppliers()
        {
           return supplierList;
        }

        public void Insert(SupplierViewModel supplier)
        {
            supplierList.Add(supplier);
        }

        public void Update(int id, SupplierViewModel supplier)
        {
            SupplierViewModel model = supplierList.Find(s => s.SuppId == id);
            model.SuppName = supplier.SuppName;
            model.City = supplier.City;
        }
    }
}
