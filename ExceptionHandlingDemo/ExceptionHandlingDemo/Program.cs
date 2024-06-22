using ExceptionProjectLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
		Customer c = new Customer();
		try
		{
            Console.WriteLine("Enter Customer Id");
			c.custId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name");
			c.custName = Console.ReadLine();

            Console.WriteLine("Enter Customer City");
			c.City = Console.ReadLine();
        }

        catch (CustomerNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
		catch (ArgumentNullException ex)
		{
            Console.WriteLine(ex.Source);
        }

        catch (AccessViolationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        finally
        {
            Console.WriteLine("Finally block called");
        }
    }
}