using System.IO;
using System.Security.AccessControl;
using ExceptionProjectLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        ////WorkingWithFilesAndDirs();
        //FileInfo fi = new FileInfo(@"C:\Users\CDAC\Desktop\Lab .net\DemoFiles\file1.txt");
        //Console.WriteLine(fi.FullName);
        //Console.WriteLine(fi.Extension);
        //Console.WriteLine(fi.CreationTime);
        //Console.WriteLine(fi.DirectoryName);
        //FileSecurity fs = fi.GetAccessControl();
        //Console.WriteLine(fs.AuditRuleType);

        //DirectoryInfo di = new DirectoryInfo(@"C:\Users\CDAC\Desktop\Lab .net\DemoFiles\file1.txt");
        //Console.WriteLine(di.FullName);
        //Console.WriteLine(di.Name);
        //Console.WriteLine(di.Parent);
        //Console.WriteLine(di.CreationTime);
        //Console.WriteLine(di.Root);


         DateTime dt = new DateTime();

        //string s = dt.ToLongDateString();
        string s = DateTime.Now.ToString("yyyy/MM/dd");
        string filename = string.Concat("customerlog.txt", s);
        string path = @"C:\Users\CDAC\Desktop\Lab .net\DemoFiles\"+ filename;
        FileStream fs = null;
        StreamWriter sw = null;
       
        try
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Customer Id");
            customer.custId = Convert.ToInt32(Console.ReadLine());

        }
        catch (CustomerNotFoundException ex)
        {
            fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
            sw = new StreamWriter(fs);
            Console.WriteLine(ex.Message);
        }
        finally
        {
            sw.Flush();
            sw.Close(); //if you dont close writer the file will not save
            fs.Close();
            fs.Dispose();
            sw.Dispose();
  
            
            
        }
    }

    private static void WorkingWithFilesAndDirs()
    {
        // WorkingWithFileInfoAndDirInfo();

    }

    private static void WorkingWithFileInfoAndDirInfo()
    {
        string path = @"C:\Users\CDAC\Desktop\Lab .net\DemoFiles\";
        //Directory.CreateDirectory(path + "Dir1");
        //File.Move(path + "file2.txt", path + "Dir1\\file2.txt");

        string[] files = Directory.GetFiles(path + "Dir1\\");
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

        string fullpath = "C:\\Users\\CDAC\\Desktop\\Lab .net\\FileHandlingDemo\\FileHandlingDemo\\FileHandlingDemo\\";
        IEnumerable<string> dirs = Directory.EnumerateDirectories(fullpath);

        foreach (string item in dirs)
        {
            Console.WriteLine(item);
        }

        bool isFound = Directory.Exists(path);
        Console.WriteLine(isFound);

        //  string path = "C:/Users/CDAC/Desktop/Lab .net/DemoFiles"; we can give path like this also
        // string path = "C:\\Users\\CDAC\\Desktop\\Lab .net\\DemoFiles\\";

        //File.Create(path + "file2.txt");

        //string p = string.Concat(path + "file1.txt");
        //string destpath = string.Concat(path + "file2.txt");

        //File.AppendAllText(p , "This is a file demo"); //write in the file

        //File.Copy(p , destpath); //copy data from one file to another file

        //File.Delete(path + "file2.txt"); //delete file

        //string contents = File.ReadAllText(p); //read from the file
        //Console.WriteLine(contents); //print that data on console

        //string source = path + "file1.txt";
        //string dest = path + "NewFiles\\file1.txt";
        //File.Move(source, dest);
    }
}