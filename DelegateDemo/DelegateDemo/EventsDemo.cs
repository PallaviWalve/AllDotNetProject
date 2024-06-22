using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLibrary;

namespace DelegateDemo
{
    internal class EventsDemo
    {
       static event ProductIdGenerationDelegate ev_AutoGenerateProductID;
        static event MathsOperations ev_DoAddition;
        static event MathsOperations ev_DoSubtraction;
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add 2. Subtract");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Maths m = new Maths();

            switch (userChoice)
            {
                case 1:
                    MathsOperations mo = new MathsOperations(m.Add);
                    ev_DoAddition += mo;

                    Console.WriteLine("Enter first Number");
                    int fno = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second Number");
                    int sno = Convert.ToInt32(Console.ReadLine());

                    int addAns = ev_DoAddition(fno, sno);
                    Console.WriteLine("Addition = "+addAns);
                    break;
                case 2:
                    MathsOperations mo1 = new MathsOperations(m.Subtract);
                    ev_DoSubtraction += mo1;

                    Console.WriteLine("Enter first Number");
                    fno = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second Number");
                    sno = Convert.ToInt32(Console.ReadLine());

                    int subAns = ev_DoSubtraction(fno, sno);
                    Console.WriteLine("Subtraction = "+subAns);
                    break; 
            }











            //Products p = new Products();
            //ProductIdGenerationDelegate delgen = new ProductIdGenerationDelegate(p.GenerateId);
            //ev_AutoGenerateProductID+= delgen;
            // int prodid = ev_AutoGenerateProductID();
            //Console.WriteLine(prodid);

            //Console.WriteLine("------------------------");

            //prodid = ev_AutoGenerateProductID();
            //Console.WriteLine(prodid);
        }
    }
}
