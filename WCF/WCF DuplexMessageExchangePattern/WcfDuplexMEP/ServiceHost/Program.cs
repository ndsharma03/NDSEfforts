using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(WcfDuplexMEP.Service1)))
            {
                host.Open();
                Console.WriteLine("Service Running successfully...");
                Console.Read();

            }
            Console.Read();
        }
    }
}
