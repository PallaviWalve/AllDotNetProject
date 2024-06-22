namespace CustomerLibrary
{
    [Serializable]
    public class Cust
    {
        public int custId { get; set; }
        public string custName { get; set; }

        [NonSerialized]
        private string _pwd;
        public string Password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }

    }
}