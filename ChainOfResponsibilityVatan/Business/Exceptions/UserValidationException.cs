using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility_First_Look.Business.Exceptions
{
    public class UserValidationException : Exception
    {
        public UserValidationException(string s)
            : base(String.Format("Invalid Property {0}", s))
        {

        }
    }
}
