using BusinessLogicLibrary;
using HelperLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("\n1.Show Customer List \n2.Insert Customer " +
                    "\n3.Delete Customer \n4.Update Customer");
        Console.WriteLine("Enter Your Choice");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        CustomerDBHelper helper = new CustomerDBHelper();

        switch (userChoice)
        {
            case 1:
                
                List<CustomerBusinessLogic> custlist = helper.GetCustlist();

                foreach (var cust in custlist)
                {
                    Console.WriteLine(cust.CustomerId);
                    Console.WriteLine(cust.CustomerName);
                }
                break;

            case 2:
                CustomerBusinessLogic c = new CustomerBusinessLogic();
                Console.WriteLine("Enter Customer Id");
                c.CustomerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                c.CustomerName = Console.ReadLine();
                helper.InsertCustomer(c);
                break;

            case 3:
                Console.WriteLine("Enter cust ID to Delete");
                int id = Convert.ToInt32(Console.ReadLine());
                CustomerBusinessLogic c1 = helper.DeleteCustomer(id);
                Console.WriteLine(c1.CustomerId);
                Console.WriteLine(c1.CustomerName);
                break;

            case 4:

                break;
            default:
                break;
        }
    }
}