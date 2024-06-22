using IndexersAndJaggedArray;
internal class Program
{
    private static void Main(string[] args)
    {
        //Products products = new Products();
        //products[0] = "GreenTea";
        //Console.WriteLine(products[0]);

        ComplexMaths c = new ComplexMaths();
        c[0, false] = 5;
        c[1, false] = 10;
        c[2, false] = 15;
        c[3, false] = 30;

        Console.WriteLine(c[3,true]);
    }
}