using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBussinessLogic
{
   
    public class Employee
    {
        public static int cnt = 1000;

        private int generateId()
        {
            return cnt;
        }
        //static Employee()
        //{
        //    cnt = cnt + 1;
        //}

        public Employee()
        {
            cnt = cnt + 1;
        }

        public Employee(string fname)
        {
            cnt = cnt + 1;
        }
        public Employee(string fname,string lname)
        {
            cnt = cnt + 1;
        }
        public Employee(string fname,string lname, int deptNo)
        {
            cnt = cnt + 1;
        }
    }
}
