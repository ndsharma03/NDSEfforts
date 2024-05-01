using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        
        public A GetMessageFromA()
        {
            Thread.Sleep(5000);
            return new ADerived() { Message = "Hello from derived class" };
        }
        [FaultContract(typeof(CustomException))]
        public string GetData(int value)
        {
            try
            {
                throw new Exception("Include custome exception in faluts is false"); //if it's true then no need to create and throw fault exception ,but it will show client entire stack trace
            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
            return "";
        }
        public string GetData(string value)
        {
            try
            {
                return "Hello from overloadded method"; // Mehtod overloading example
            }
            catch (Exception e)
            {
                throw new CustomException(e.Message);
            }
            return "";
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


    }

    public class CustomException : FaultException
    {
        public CustomException() : base() { }
        public CustomException(string message) : base(message) { }
    }
}
