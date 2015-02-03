namespace DoubleColor.Redballs.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Summary description for DoubleBallException
    /// </summary>
    public class DoubleBallException : Exception
    {
        public DoubleBallException(string message) : base(message) 
        {
        }
    }


    public class IdentityExistDoubleBallException : DoubleBallException
    {
        public IdentityExistDoubleBallException(string messgae)
            : base(messgae)
        { 
        }
    }

    public class ArgumentDoubleBallException : DoubleBallException
    {
        public ArgumentDoubleBallException(string messgae)
            : base(messgae)
        { 
        }
    }

    public class AuthenticationDoubleBallException : DoubleBallException
    {
        public AuthenticationDoubleBallException(string messgae)
            : base(messgae)
        {
        }
    }
}