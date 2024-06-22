namespace DelegatesLibrary
{
    public delegate int ProductIdGenerationDelegate();
    public delegate void WorkingWithProductData();
    public delegate void productDeleteFind(string name);
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }

        static List<Products> productsList = new List<Products>()
        {
            new Products {ProductId = 1, ProductName = "Tea", Price = 10,CategoryId = 1},
            new Products {ProductId = 2, ProductName = "Coffee", Price = 20,CategoryId = 1},
            new Products {ProductId = 3, ProductName = "Bournvita", Price = 25, CategoryId = 1},
            new Products {ProductId = 4, ProductName = "Boost", Price = 30 , CategoryId = 1},
            new Products {ProductId = 5, ProductName = "Green Tea", Price = 15, CategoryId = 1},
        
            new Products {ProductId = 6, ProductName = "Lays", Price=10 , CategoryId = 2},
            new Products {ProductId = 7, ProductName = "Punjabi Tadaka", Price=10 , CategoryId = 2}
        };


        static int cnt = 0;
        public int GenerateId()
        {
          cnt = cnt + 1;
          return cnt;
        }

        public void AddProduct(Products p)
        {
            productsList.Add(p);
        }

        public void UpdateProduct(int id, Products p)
        {
           Products foundProduct =  productsList.Find(p => p.ProductId == id);
            if (foundProduct != null)
            {
                foundProduct.ProductId = id;
                foundProduct.ProductName = p.ProductName;
                foundProduct.Price = p.Price;
            }
            else
            {
                Console.WriteLine("Product Id Not Found");
            }
        }

        public List<Products> FindByCategoryId(int categoryId)
        {
            List<Products> allProductsInCategory = productsList.FindAll(p => p.CategoryId == categoryId); //p is scope variable
            return allProductsInCategory;
        }
        public void DeleteProduct(string name)
        {
            Products foundProduct = productsList.Find(p => p.ProductName == name);
            
            Console.WriteLine("Found the following product details...confirm whether you want to delete or not");
            Console.WriteLine(foundProduct.ProductId);
            Console.WriteLine(foundProduct.ProductName);
            Console.WriteLine(foundProduct.Price);
            Console.WriteLine("Press y if You Want to Delete");

            char userChoice = Convert.ToChar(Console.ReadLine());
            if(userChoice == 'y')
            {
                productsList.Remove(foundProduct);
                Console.WriteLine("Product Successfully Deleted...");
            }
           
        }
        public Products findProductByName(string name)
        {
            Products foundProduct = productsList.Find(p => p.ProductName == name);
          
                return foundProduct;
            
        }
        public List<Products> ShowUpdatedDetails()
        {
            return productsList;
        }
    }
}