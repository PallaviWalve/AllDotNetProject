using BusinessLogicLibrary;
using HelperLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("\n1.Show \n2.Insert \n3.Find " +
                         "  \n4.Delete \n5.Update");

        int ch = Convert.ToInt32(Console.ReadLine());
        CustomerHelper helper = new CustomerHelper();
        switch (ch)
        {
            case 1:
                List<CustomerBAL> list = new List<CustomerBAL>();
                list = helper.GetCustomers();

                foreach (CustomerBAL item in list)
                {
                    Console.WriteLine(item.CustomerId);
                    Console.WriteLine(item.CustName);
                }
                break;

            case 2:
                CustomerBAL customer = new CustomerBAL();
                customer.CustomerId = 10;
                customer.CustName = "Guari";

               helper.InsertCustomer(customer);
                break;

            case 3:
                List<CustomerBAL> lists = new List<CustomerBAL>();
                lists = helper.GetCustomers();
                Console.WriteLine("Enter the Id");
                int id = Convert.ToInt32(Console.ReadLine());   

                foreach (CustomerBAL item in lists)
                {
                    if (item.CustomerId == id)
                    {
                        Console.WriteLine(item.CustomerId);
                        Console.WriteLine(item.CustName);
                    }
                   
                }
                break;

            case 4:
                CustomerBAL c = new CustomerBAL();
                Console.WriteLine("Enter Id to Delete");
                int custid = Convert.ToInt32(Console.ReadLine());
                helper.DeleteCustomer(custid);
                Console.WriteLine("Customer Deleted");
                break;
        }
    }
}