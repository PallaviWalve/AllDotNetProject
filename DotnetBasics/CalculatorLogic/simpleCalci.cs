namespace CalculatorLogic
{
    public class simpleCalci
    {
        public int AddNos(int fno, int sno)
        {
            return fno + sno;
        }

        public Tuple<int,int> GetMultipleValues(int a , int b)
        {
               int min, max;
            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }
            return new Tuple<int,int>(max, min);
        }
         public int GetMultiplyAndDiv(int fno, int sno,out int divAns)
        {
            int multAns = fno * sno;
            divAns = fno / sno;
            return multAns;
        }

        public void swapNos(ref int fno, ref int sno)
        {
            int temp;
            temp = sno;
            sno = fno;
            fno = temp;
            Console.WriteLine("In the library " + fno);
            Console.WriteLine("In the library " + sno);
        }
        
    }
}