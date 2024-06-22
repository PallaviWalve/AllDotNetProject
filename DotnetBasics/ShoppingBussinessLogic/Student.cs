using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBussinessLogic
{
    public class Student
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string city { get; set; }
        public Student()
        {
            Console.WriteLine("I am Default Constructor");
        }

        public Student(String fname, string lname)
        {
            Console.WriteLine("I parameterized constructor of Parent");
            this.firstName = fname;
            this.lastName = lname;
            
        }

        public Student(String fname, string lname, string cityName):this(fname, lname) //this is called as constructor chaining
        {
            this.city = cityName;
        }
    }
}
