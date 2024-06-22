using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAndJaggedArray
{
    internal class ComplexMaths
    {
        int[] arr = new int[10];

        public int this[int index, bool ans]
        {
            get 
            {
                if (ans)
                {
                    return arr[index] * arr[index];
                }
                else
                {
                    return arr[index];
                }
            }
            set 
            { 
                if (ans)
                {
                    arr[index] = (int)Math.Sqrt(value);
                }
                else
                {
                    arr[index] = value;
                }
            }
        }
    }
}
