using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_Cars
{
    [DataContract]
    [Serializable]
    public class Car
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Tpye { get; set; }
        [DataMember]
        public string PlateNumber { get; set; }
        [DataMember]
        public int Age { get; set; }
    }
}