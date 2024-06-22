using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class LambdaDemo
    {
        static void Main(string[] args)
        {
            Func<int,int> square = num => {
                int ans = num * num;
                return ans;
            };

            int sq_ans = square(10);
            Console.WriteLine("Square = "+sq_ans);

            Console.WriteLine("-------------------");

            Action<int, int> multiply = (i, j) =>
            {
                int ans = i * j;
                Console.WriteLine("Multiplication = "+ans);
            };
            multiply(12, 32);

            Console.WriteLine("-------------------");

            Predicate<int> CheckIfNumberIsPositive = i =>
            {
                return i > 0;
            };
            bool ans = CheckIfNumberIsPositive(10);
            Console.WriteLine(ans);
        }
    }
}
