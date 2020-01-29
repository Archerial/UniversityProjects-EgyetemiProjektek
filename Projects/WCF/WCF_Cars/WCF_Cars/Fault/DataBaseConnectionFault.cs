using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WCF_Cars.Fault
{
    [DataContractAttribute]
    public class DataBaseConnectionFault
    {
        private string report;

        public DataBaseConnectionFault(string message)
        {
            this.report = message;
        }

        [DataMemberAttribute]
        public string Message
        {
            get { return this.report; }
            set { this.report = value; }
        }
    }
}