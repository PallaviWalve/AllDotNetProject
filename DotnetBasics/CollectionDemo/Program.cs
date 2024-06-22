using System.Collections;
using SchoolManagementLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int choice = 3;
        switch(choice)
        {
            case 1:

                PhoneBookUsing_HashTable pb = new PhoneBookUsing_HashTable();
                pb.populateEntries();
                Console.WriteLine("\nEnter the number to find the Name");
                int k = Convert.ToInt32(Console.ReadLine());
                string name = pb.FindName(k);
                Console.WriteLine("\n" + name);
                pb.AddData(8965, "Gauri");
                pb.display();
                break;

            case 2:
                StudentSortedList student = new StudentSortedList();
                student.display();
                Console.WriteLine("------------------------------");
                student.AddStudent(3, "Gauri");
                Console.WriteLine("-------------------------------");
                student.display();
                break;

            case 3:
                 ArrayListDemo demo = new ArrayListDemo();
                ArrayList list = demo.GetTheArrayList();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                demo.AddElement(4000);
                Console.WriteLine("--------------");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                break;

            default:
                break;
        }
            

    }
}