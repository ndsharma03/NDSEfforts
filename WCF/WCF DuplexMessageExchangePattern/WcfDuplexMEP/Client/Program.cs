using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Client.ServiceReference1;
namespace Client
{
   // [CallbackBehavior(UseSynchronizationContext=false)]// this attrubute required if callback operation is not oneway.
    class Program:IService1Callback
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            p.RunService();
            Console.Read();
        }

        public void RunService()
        {
            InstanceContext context = new InstanceContext(this);
            Service1Client client = new Service1Client(context);
            client.ProcessReport(33);
        }


        public void Progress(int percentageComple)
        {
            Console.WriteLine(" Operation completion percent =" + percentageComple + " % ");
        }
    }
}
