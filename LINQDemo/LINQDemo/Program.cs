using LINQDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        //EvenNos();

        List<Employee> emplist = new List<Employee>()
        {
            new Employee { EmpId = 1,EmpName = "Rudra", City = "Pune", Salary = 25000},
            new Employee { EmpId = 2, EmpName = "Dhruva", City = "Mumbai",Salary = 35000 },
            new Employee { EmpId = 3, EmpName = "Harsh", City = "Pune",Salary = 45000 },
            new Employee { EmpId = 4, EmpName = "Tej", City = "Pune", Salary = 40000 }
        };

        var findEmployees = (from e in emplist
                             select new { Salary = (e.Salary * .10) }).Last();

        emplist.Add(new Employee { EmpId = 5, EmpName = "Avi", City = "Mumbai", Salary = 45000 });

        Console.WriteLine(findEmployees.Salary);



        //Console.WriteLine("ID" + "\t\tName" + "\t\tCity" +"\t\tSalary");
        //foreach (Employee emp in findEmployees. )
        //{

        //    Console.WriteLine("\n"+emp.EmpId +"\t\t" + emp.EmpName +"\t\t" + emp.City +"\t\t" +emp.Salary);


        //}

    }

    private static void EvenNos()
    {
        Console.WriteLine("Hello, World!");

        //int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //var evenNos = from a in arr
        //              where a%2 == 0
        //              select a;

        //foreach ( var i in evenNos )
        //{
        //    Console.WriteLine(i);
        //}
    }
}