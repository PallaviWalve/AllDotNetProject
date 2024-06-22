using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAndJaggedArray
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[,] multi = new int[3, 3]; //Multi-dimensional
            multi[0, 0] = 1;
            multi[0, 1] = 2;
            multi[0, 2] = 3;
            multi[1, 0] = 4;
            multi[1, 1] = 5;
            multi[1, 2] = 6;
            multi[2, 0] = 7;
            multi[2, 1] = 8;
            multi[2, 2] = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(multi[i,j] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("--------------------");

            int[][] jagged = new int[4][];
            jagged[0] = new int[4] {1,2,3,4};
            jagged[1] = new int[5] {11,12,13,14,15};
            jagged[2] = new int[2] { 21, 22 };
            jagged[3] = new int[10] { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 };

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length;j++)
                {
                    Console.Write(jagged[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
