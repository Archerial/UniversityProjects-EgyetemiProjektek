using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WCF_Cars
{
    [DataContract]
    public class Client
    {
        [DataMember]
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        private string guid;
        public string GUID
        {
            get { return guid; }
            set { guid = value; }
        }

        public Client(string username, string guid)
        {
            this.Username = username;
            this.GUID = guid;
        }

    }
}