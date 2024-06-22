namespace ShoppingBussinessLogic
{
    public class Products
    {
        //write only
        private string _pwd;
        public string Password {
            set
            {
                _pwd = value;
            }
        }
        //read only
        public float GST {
            get {
                return 5.0f; 
            }
                 //private set { }
        } 
           

        private int _prodid;
        public int ProductId
		{
			get { 
				return _prodid; 
			}
			set { 
				if (value > 0)
				{
					_prodid = value;
				}
				else
				{
					Console.WriteLine("Product id not valid");
				}
			}
		}

        private string _prodName;
        public string ProductName
        {
            get
            {
                return _prodName;
            }
            set
            {
                _prodName = value;
            }
        }

        public double Price { get; set; } = 1.0D;

        public string UnitOfMeasurement { get; set; } = "unknown";


    }
}