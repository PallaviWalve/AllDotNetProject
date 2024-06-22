using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBussinessLogic
{
    public class Manager : Student
    {
        public Manager(string fname, string lname, string managerName):base(fname, lname, managerName)
        {
            Console.WriteLine("Parameterized of child");
        }
    }
}
