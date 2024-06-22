using System.Collections.Generic;
using SchoolManagementLibrary;
using System.Collections;

internal class Program
{

    private static void Main(string[] args)
    {
        //Stack s = new Stack();
        //s.Push(2);
        //s.Push(3.34f);

        ////Non Generic 
        //s.Push(3456);
        //foreach (var item in s)
        //{
        //    Console.WriteLine(item);
        //}
        //s.Pop(); //3456
        //s.Peek(); //3.45f
        //s.Contains(2); //true ---> check element present or not
        ////Array myarr = Array.CreateInstance(typeof(object), 10);
        //object[] myarr = new object[5];
        //s.CopyTo(myarr, 0);
        //int cnt = s.Count;
        //object[] objArr = new object[cnt];
        //objArr = s.ToArray();

        //Queue queue = new Queue();
        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(3);
        //queue.Dequeue(); //1
        //queue.Peek(); //2

        //Hashtable ht = new Hashtable();
        //ht.Add(1, "Ankita");
        //ht.Add("1", "Arpita");
        //ht.Add(2, "Bob");
        //ht.Add(3, "Kajal");
        //ht.Add(4, "Dhanoo");
        //ht.Add(5, "Suresh");

        //IDictionaryEnumerator ie = ht.GetEnumerator();
        //while (ie.MoveNext()) 
        //{
        //    Console.WriteLine(ie.Key + " " + ie.Value);
        //}

        //Console.WriteLine("---------------------------");
        //string name = (string)ht[5];
        //Console.WriteLine(name);

        //WorkingWithArrays();
        StudentOperations();

    }

    private static void StudentOperations()
    {
       
            StudentOperations operations = new StudentOperations();
        int userChoice;
        do
        {
            Console.WriteLine("1.Add Student \n2.Edit Student \n3.Get All Student \n4.Delete Student \n5.Exit");
           userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Student s = new Student();
                    Console.WriteLine("Enter Roll Number");
                    s.RollNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    s.StudentName = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    s.City = Console.ReadLine();
                    operations.AddStudent(s);
                    break;

                case 2:
                    break;

                case 3:
                    List<Student> students = new List<Student>();
                    students = operations.GetStudent();
                    foreach (Student student in students)
                    {
                        Console.WriteLine(student.RollNo);
                        Console.WriteLine(student.StudentName);
                        Console.WriteLine(student.City);
                    }
                    break;
                case 4:
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        } while (userChoice!=0);

    }

//private static void WorkingWithArrays()
//{
//    Console.WriteLine("Hello, World!");

//    object obj;
//    var o1 = 13.4f;
//    //dynamic o2 = obj as dynamic;

//    float i = 10.43f;

//    obj = i; //Boxing
//    Type t = obj.GetType();
//    Console.WriteLine(t);

//    float h = (float)obj; //Unboxing done using casting
//    Console.WriteLine(h);
//    Console.WriteLine(h.GetType());

//    int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//    Array.Sort(arr);
//    Array.Reverse(arr);
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }


//    int[] arr2 = new int[] { 11, 12, 13, 14, 15 };

//    int[] arr3 = new int[5];

//    arr[0] = 1;
//    arr[1] = 2;
//    arr[2] = 3;
//    arr[3] = 4;
//    arr[4] = 5;

//    Array typedArray = Array.CreateInstance(typeof(int), 5);
//    typedArray.SetValue(101, 0);
//    typedArray.SetValue(102, 1);
//    typedArray.SetValue(103, 2);
//    typedArray.SetValue(104, 3);
//    typedArray.SetValue(105, 4);
//}
}
