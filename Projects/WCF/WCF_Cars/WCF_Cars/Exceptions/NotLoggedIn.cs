using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Cars.Exceptions
{
    public class NotLoggedIn : Exception
    {
        public NotLoggedIn()
        {
        }

        public NotLoggedIn(string message)
        : base(message)
        {
        }
        public NotLoggedIn(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}