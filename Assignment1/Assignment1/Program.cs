using System.Collections.Generic;
using System.Collections;
using CustomerLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomerOperations operations = new CustomerOperations();
        int userChoice;
        do
        {
            Console.WriteLine("1.Add Customer \n2.Get All Customer \n3.Exit");
            userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Customer s = new Customer();
                    Console.WriteLine("Enter Customer Id");
                    s.custId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Customer Name");
                    s.custName = Console.ReadLine();
                    Console.WriteLine("Enter Customer City");
                    s.City = Console.ReadLine();
                    operations.AddCustomer(s);
                    break;
                case 2:
                    List<Customer> customers = new List<Customer>();
                    customers = operations.GetCustomer();
                    foreach (Customer customer in customers)
                    {
                        Console.WriteLine(customer.custId);
                        Console.WriteLine(customer.custName);
                        Console.WriteLine(customer.City);
                    }
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
           
                default:
                    break;
            }
        } while (userChoice != 0);

    }
}
