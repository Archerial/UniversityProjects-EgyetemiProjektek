using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCF_Cars_HOST
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCF_Cars.CarService)))
            {
                host.Open();
                Console.WriteLine("Host has started @" + DateTime.Now.ToString());

                Console.ReadLine();
            }
            
        }
    }
}
