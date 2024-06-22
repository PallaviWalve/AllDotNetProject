
namespace ExceptionProjectLibrary
{
    public class Customer
    {
        int _custId;
        string _custName;
        string _city;
        public int custId 
        { 
            get 
            { 
                return _custId;
            } 
            set 
            { 
                if(value > 0 && value < 2000)
                {
                    _custId = (int)value;
                }

                else if(value > 2000  )
                {
                    throw new CustomerNotFoundException("This is Invalid customer Id");
                }
                else
                {
                    throw new ArgumentNullException("Customer Id must be a Positive Number");
                }
                
            }
        }
        public string custName 
        { 
            get 
            { 
                return _custName; 
            } 
            set 
            { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer Name cannot be Null or Empty");
                }

                else if (value.StartsWith(" "))
                {
                    throw new AccessViolationException("Name cannot starts with space");
                }
                else
                {
                    _custName = value;
                }
               
            } 
        }
        public string City 
        { 
            get 
            { 
                return _city;
            }
            set 
            { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("City cannot be Null or Empty");
                }
                _city = value;
            }
        }
    }
}