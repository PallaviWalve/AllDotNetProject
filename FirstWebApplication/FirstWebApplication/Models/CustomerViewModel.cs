namespace FirstWebAppMVC.Models
{
    public class CustomerViewModel
    {
        private int _custid;

        public int CustomerId
        {
            get { return _custid; }
            set { _custid = value; }
        }

        private string _custname;

        public string CustName
        {
            get { return _custname; }
            set { _custname = value; }
        }

    }
}
