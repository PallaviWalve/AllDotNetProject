using BusinessLogicLibrary;
using DataAccessLibrary;

namespace HelperLibrary
{
    public class CustomerHelper
    {
        CustomerDAL dal = new CustomerDAL();
        public List<CustomerBAL> GetCustomers()
        {
            List<CustomerBAL> custlist = dal.GetCustomers();
            return custlist;
        }

        public void InsertCustomer(CustomerBAL cust)
        {
            dal.InsertCustomer(cust);
        }
        public void DeleteCustomer(int id)
        {
            dal.DeleteCustomer(id);
        }

        public CustomerBAL FindCustomer(int id)
        {
            dal.FindCustomer(id);

        }
    }
}