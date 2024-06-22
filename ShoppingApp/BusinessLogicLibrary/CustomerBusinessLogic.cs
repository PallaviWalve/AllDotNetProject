namespace BusinessLogicLibrary
	
{
    public class CustomerBusinessLogic
    {
		private int _custId;

		public int CustomerId
		{
			get 
			{ 
				return _custId;
			}
			set 
			{
				_custId = value;
			}
		}

		private string _custName;

		public string CustomerName
		{
			get 
			{ 
				return _custName;
			}
			set 
			{ 
				_custName = value; 
			}
		}

	}
}