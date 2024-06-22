using CustomerLibrary;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1.Binary Serialization " +
                            "\n2.Binary Deserialization " +
                            "\n3.XML Serialization " +
                            "\n4.XML Deserialization" +
                            "\n5.JSON Serialization" +
                            "\n6.JSON Deserialization");

        Console.WriteLine("Enter Your Choice");
        int ch = Convert.ToInt32(Console.ReadLine());

        switch(ch)
        {
            case 1:
                FileStream fs = new FileStream("C:\\Users\\CDAC\\Desktop\\" +
                    "Lab .net\\DemoFiles\\custbin.dat", 
                    FileMode.CreateNew,FileAccess.Write);

                Cust c = new Cust();
                c.custId = 11;
                c.custName = "Pallavi";
                c.Password = "password";
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, c);
                fs.Close();
                fs.Dispose();
                break;

            case 2:
                FileStream fs1 = new FileStream("C:\\Users\\CDAC\\Desktop\\" +
                    "Lab .net\\DemoFiles\\custbin.dat", 
                    FileMode.Open, FileAccess.Read);

                BinaryFormatter bf1 = new BinaryFormatter();
                Cust c1 = (Cust)bf1.Deserialize(fs1);
                Console.WriteLine(c1.custId);
                Console.WriteLine(c1.custName);
                Console.WriteLine(c1.Password);
                fs1.Close();
                fs1.Dispose();
                break;

            case 3:
                FileStream fs2 = new FileStream("C:\\Users\\CDAC\\Desktop\\" +
                    "Lab .net\\DemoFiles\\custxmldata.xml", 
                    FileMode.CreateNew, FileAccess.Write);
                   
                XmlSerializer xser = new XmlSerializer(typeof(Cust));
                Cust c2 = new Cust();
                c2.custId = 12;
                c2.custName = "Pallavi";
                c2.Password = "password";
                xser.Serialize(fs2, c2);
                fs2.Close();
                break;

            case 4:
                FileStream fs3 = new FileStream("C:\\Users\\CDAC\\Desktop\\" +
                  "Lab .net\\DemoFiles\\custxmldata.xml",
                  FileMode.Open, FileAccess.Read);

                XmlSerializer xser1 = new XmlSerializer(typeof(Cust));
                Cust d = (Cust)xser1.Deserialize(fs3);
                Console.WriteLine(d.custId);
                Console.WriteLine(d.custName);
                Console.WriteLine(d.Password);
                fs3.Close();
                break;

            case 5:
                FileStream fs4 = new FileStream("C:\\Users\\CDAC\\Desktop\\" +
                   "Lab .net\\DemoFiles\\custjsondata.json",
                   FileMode.CreateNew, FileAccess.Write);
                DataContractSerializer data = new DataContractSerializer(typeof(Cust));
                Cust d1 = new Cust();
                d1.custId = 13;
                d1.custName = "Pallavi";
                d1.Password = "password";
                MemoryStream ms = new MemoryStream();
                data.WriteObject(ms, d1);
                fs4.Write(ms.ToArray());
                fs4.Close();
                ms.Close();
                break;

            case 6:
                FileStream fs5 = new FileStream("C:\\Users\\CDAC\\Desktop\\" +
                 "Lab .net\\DemoFiles\\custjsondata.json",
                 FileMode.Open, FileAccess.Read);

                DataContractSerializer data1 = new DataContractSerializer(typeof(Cust));
                Cust d3 = (Cust)data1.ReadObject(fs5);
                Console.WriteLine(d3.custId);
                Console.WriteLine(d3.custName);
                Console.WriteLine(d3.Password);
                fs5.Close();
                break;

            default:
                break;
        }
    }
}