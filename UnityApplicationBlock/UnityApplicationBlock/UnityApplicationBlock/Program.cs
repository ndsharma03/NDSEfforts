using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
namespace UnityApplicationBlock
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class FileLogger : ILogger
    {
        public FileLogger() { }
        public void Log(string message)
        {
            Console.WriteLine("Logging into File");
        }
    }
    public class DBLogger : ILogger
    {
        public DBLogger() { }
        public void Log(string message)
        {
            Console.WriteLine("Logging into Database");
        }
    }

    public abstract class Customer
    {
        ILogger _logger;
        public Customer(ILogger logger)
        {
            _logger = logger;
        }
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        
        public void AddCustomer(Customer cust)
        {
            _logger.Log(cust.ToString());
        }
        public override string ToString()
        {
            return Name+"  "+Age;
        }
    }
    public class GoldCustomer : Customer
    {
       public  GoldCustomer(ILogger logger) : base(logger)
        {

        }
        public override string Name { get; set; }
        public override int Age { get; set; }
    }
    public class SilverCustomer : Customer
    {
        public SilverCustomer(ILogger logger) : base(logger) { }
        public override string Name { get; set; }
        public override int Age { get; set; }
    }
    /// <summary>
    /// https://docs.microsoft.com/en-us/previous-versions/msp-n-p/ff650806%28v%3dpandp.10%29
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, DBLogger>();
            container.RegisterType<ILogger, DBLogger>("DBLogger");
            container.RegisterType<ILogger, FileLogger>("FileLogger");
            container.RegisterType<Customer, GoldCustomer>("GoldCustomer");
            container.RegisterType<Customer, SilverCustomer>("SilverCustomer");

            Console.WriteLine("DB Logger Resolving :");
            container.Resolve<ILogger>("DBLogger").Log("I am DBLogger");

            Console.WriteLine("File Logger Resolving :");
            container.Resolve<ILogger>("FileLogger").Log("I am DBLogger");

            Console.WriteLine("GoldCustomer Resolving :"); //Question : How to tell Unity to use FileLogger for gold customers??
            container.Resolve<Customer>("GoldCustomer").ToString();

            Console.WriteLine("SilverCustomer Resolving :");
            container.Resolve<Customer>("SilverCustomer").ToString();

        }
    }
}
q