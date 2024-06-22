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
                CustomerBAL customerBAL = new CustomerBAL();
                Console.WriteLine("Enter Id to Find Customer");
                int id = Convert.ToInt32(Console.ReadLine());
                helper.FindCustomer(id);

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