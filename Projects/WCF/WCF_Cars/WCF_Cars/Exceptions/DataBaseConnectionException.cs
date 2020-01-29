using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Cars.Exceptions
{
    public class DataBaseConnectionException : Exception
    {
        public DataBaseConnectionException()
        {
        }

        public DataBaseConnectionException(string message)
        : base(message)
        {
        }
        public DataBaseConnectionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}