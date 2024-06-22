using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLibrary
{
    public class SignUp
    {
        string _firstName;
        string _lastName;
        string _email;
        string _createPassword;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;

            }
            set
            {
                _lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set 
            { 
                _email = value; 
            }
        }
        public string CreatePassword
        {
            get
            {
                return _createPassword;
            }

            set 
            { 
                _createPassword = value; 
            }
        }
    }
}
