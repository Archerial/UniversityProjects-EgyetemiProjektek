using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Cars.Exceptions
{
    public class IdNotFoundException : Exception
    {

        public IdNotFoundException()
        {
        }

        public IdNotFoundException(string message)
        : base(message)
        {
        }
        public IdNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}