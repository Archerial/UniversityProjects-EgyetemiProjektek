using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WCF_Cars.Fault
{
    [DataContractAttribute]
    public class IdNotFoundFault
    {
            private string report;

            public IdNotFoundFault(string message)
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