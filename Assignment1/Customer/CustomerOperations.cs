using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public class CustomerOperations
    {
        public static List<Customer> customerList = new List<Customer>();

        static CustomerOperations()
        {
            customerList.Add(new Customer(id: 1, city: "Pune", name: "Pallavi"));

            customerList.Add(new Customer(2, "Kajal", "Nashik"));

            customerList.Add(new Customer(3, "Shreya", "Bangalor"));
        }

        public void AddCustomer(Customer customer)
        {
            //Student s = new Student(rno:student.RollNo, name:student.StudentName, city:student.City);

            Customer s = new Customer();
            s.custId = customer.custId;
            s.custName = customer.custName;
            s.City = customer.City;
            customerList.Add(s);

        }

        public List<Customer> GetCustomer()
        {
            return customerList;
        }

    }
}
