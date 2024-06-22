using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAndJaggedArray
{
  
        public class Products
        {
            string[] productnames = new string[5] {"Tea", "Coffee", "Biscuits","Water","Milk" };
            public string this[int index]
            {
                get 
                { 
                    /* return the specified index here */ 
                    return productnames[index];
                }
                set 
                {
                    /* set the specified index to value here */
                    productnames[index] = value;
                }
            }
        }
    }

