using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLibrary;

namespace DelegateDemo
{
    internal class ProductsOperations
    {
        static void Main(string[] args)
        {
            Products p = new Products();

            Console.WriteLine("1.Add \n2.Delete \n3.Update \n4.Show List \n5.Find Product \n0.Exit");
            Console.WriteLine("\nEnter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Products newProduct = new Products();

                        Console.WriteLine("Enter Product ID");
                        newProduct.ProductId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Product Name");
                        newProduct.ProductName = Console.ReadLine();

                        Console.WriteLine("Enter Product Price");
                        newProduct.Price = Convert.ToInt32(Console.ReadLine());

                        p.AddProduct(newProduct);

                        break;

                    case 2:
                        Console.WriteLine("Enter Product Name");
                        p.ProductName = Console.ReadLine();
                        p.DeleteProduct(p.ProductName);
                        break;

                    case 3:
                        Console.WriteLine("Enter the Product Id to update");
                        int propid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the New Product Id");
                        Products updateProducts = new Products();
                        updateProducts.ProductId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter new Product Name");
                        updateProducts.ProductName = Console.ReadLine();

                        Console.WriteLine("Enter New Price");
                        updateProducts.Price = Convert.ToInt32(Console.ReadLine());

                        p.UpdateProduct(propid, updateProducts);
                        Console.WriteLine("\nShowing Updated Details");
                        List<Products> updatedDet = p.ShowUpdatedDetails();

                        updatedDet.ForEach(item => {
                            Console.WriteLine("\nProduct Id : " + item.ProductId
                              + "\nProduct Name : " + item.ProductName
                              + "\nProduct Price : " + item.Price);
                        });
                        break;

                    case 4:
                        Console.WriteLine("Enter Category Of the Product");
                        int catId = Convert.ToInt32(Console.ReadLine());
                        List<Products> list = p.FindByCategoryId(catId);
                        list.ForEach(item =>
                        {
                            Console.WriteLine("\nProduct Id : " + item.ProductId
                               + "\nProduct Name : " + item.ProductName
                               + "\nProduct Price : " + item.Price);
                        });

                        double AvgPrice = list.Average(item => item.Price);
                        Console.WriteLine("\nAverage Price : " + AvgPrice);

                        int maxPrice = list.Max(item => item.Price);
                        Console.WriteLine("\nMaximum Price : " + maxPrice);

                        int minPrice = list.Min(item => item.Price);
                        Console.WriteLine("\nMinimum Price : " + minPrice);



                        //foreach (var item in list)
                        //{
                        //    Console.WriteLine("\nProduct Id : " + item.ProductId 
                        //        + " Product Name : " + item.ProductName 
                        //        +" Product Price : " + item.Price);
                        //}
                        break;

                    case 5:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Entered Choice is Invalid");
                        break;
                }
            
        }
    }
}
