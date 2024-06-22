internal class Program
{
    private static void Main(string[] args)
    {
        Print1to10();
        Task<int> ans = MultipyNos(2, 3);
        Console.WriteLine("Answer = "+ans.Result);
        PrintHello();
        Console.ReadLine();
    }

    public static async void Print1to10()
    {
        await Task.Run(() =>
        {
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
                Task.Delay(100);
            }
        });
    }
    public static async void PrintHello()
    {
        await Task.Run(() =>
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello");
                Task.Delay(100).Wait();
            }
        });
    }

    public static async Task<int> MultipyNos(int i, int j)
    {
        int ans = 0;
        await Task.Run(() => 
        {
            for (int i = 0; i <= 10; i++)
            {
                ans = i * j * 10;
            }
           
        }); 
        return ans;
    }
}