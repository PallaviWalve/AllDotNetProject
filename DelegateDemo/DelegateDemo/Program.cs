using DelegatesLibrary;

public delegate int DivRem(int numerator, int denominator);
internal class Program
{
    private static void Main(string[] args)
    {
        Products p = new Products();
        ProductIdGenerationDelegate delobj = new ProductIdGenerationDelegate(p.GenerateId);
       
        int productid = delobj.Invoke();
        Console.WriteLine(productid);
       
        Console.WriteLine("--------------");
        productid = delobj(); //We can write this without using invoke()
        Console.WriteLine(productid);
       
        //Console.WriteLine("---------------");
        //WorkingWithProductData[] delobj1 = new WorkingWithProductData[2] 
        //        { p.AddProduct, p.UpdateProduct }; //two methods to invoke

        //WorkingWithProductData del = (WorkingWithProductData) MulticastDelegate.Combine(delobj1);
        //typecast done here because i want my type of delegate
       //del();

        Console.WriteLine("-----------------------");

        //productDeleteFind del1 = new productDeleteFind(p.DeleteProduct);
        //productDeleteFind del2 = new productDeleteFind(p.findProductByName);

        //productDeleteFind combinedDel = (productDeleteFind) MulticastDelegate.Combine(del1, del2);
        //combinedDel.Invoke("Tea");

        Console.WriteLine("-----------Anonymous Delegates -------------");

        productDeleteFind anonDel = delegate (string n)
        {
            Console.WriteLine("Anonymous Method Called");
            Console.WriteLine(n.ToUpper()); //convert string to upper case
        };

        anonDel("Hello World");
        Console.WriteLine("---------------");

        DivRem dm = delegate (int i, int j)
        {
            long rem;
            long o = Math.DivRem(i, j, out rem);
            return Convert.ToInt32(rem);
        };

        int remainder = dm(13, 2);
        Console.WriteLine(remainder);
    }
}