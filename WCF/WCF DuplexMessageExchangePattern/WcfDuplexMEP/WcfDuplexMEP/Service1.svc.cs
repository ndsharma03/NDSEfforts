using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WcfDuplexMEP
{

    // [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)] //this attrubute required if callback operation is not oneway.
    public class Service1 : IService1
    {
        public void ProcessReport(int value)
        {
            Console.WriteLine("Report processing Started");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                OperationContext.Current.GetCallbackChannel<IServiceCallback>().Progress(i);
            }
            Console.WriteLine("Report processing Ended");

        }

        
    }
}
