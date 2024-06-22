namespace FormLibrary
{
    public class Login
    {
        string _userName;
        string _password;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }


        }
    }
}
