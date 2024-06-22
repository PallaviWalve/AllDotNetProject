using BusinessLogicLibrary;
using ShoppingDBLibrary;
namespace HelperLibrary
{
    public class CustomerDBHelper
    {
        CustomerDataAccess custdal = new CustomerDataAccess();
        public List<CustomerBusinessLogic> GetCustlist()
        {
           
            List<CustomerBusinessLogic> custs = new List<CustomerBusinessLogic>();
            custs = custdal.ShowCustomerList();
            return custs;
        }

        public void InsertCustomer(CustomerBusinessLogic c)
        {
            custdal.InsertCustomer(c);
        }

        public CustomerBusinessLogic DeleteCustomer(int id)
        {
            CustomerBusinessLogic c = new CustomerBusinessLogic();
             c = custdal.DeleteCustomer(id);
            return c;
        }

        public void UpdateCustomer(int id, CustomerBusinessLogic c)
        {

            custdal.UpdateCustomer(id, c);

        }
    }
}