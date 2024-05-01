using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDuplexMEP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract=typeof(IServiceCallback)) ] //<<========Call back contract
    public interface IService1
    {

        [OperationContract]
        void ProcessReport(int value);

       
    }
    public interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void Progress(int percentageComple);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
  
}
