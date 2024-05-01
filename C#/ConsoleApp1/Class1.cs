using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    interface IDiscount
    {
        void getDiscount();
    }
    interface IDatabase
    {
        void Add();
    }
    public abstract class Customer : IDatabase, IDiscount
    {
        public void Add()
        {
            Console.WriteLine("Add");
        }

        public void getDiscount()
        {
            Console.WriteLine("getDiscount");
        }
    }
    public class GoldCustomer : Customer
    {
    }
    public class SilverCustomer : Customer
    {

    }
    public class Inquiry : IDiscount
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void getDiscount()
        {
            Console.WriteLine("Inquiry.getDiscount");
        }
    }
    class Class1
    {

        public static void Main()
        {
            List<Customer> lstCustomer = new List<Customer>();
            lstCustomer.Add(new GoldCustomer());
            lstCustomer.Add(new SilverCustomer());
            
        }

        //////public static void Main()
        //////{
        //////    Task t = M1Wrapper();

        //////    //Other Operation ....

        //////    for (int i = 0; i < 10; i++)
        //////    {
        //////        Console.WriteLine("Main i=" + i);
        //////    }
        //////    t.Wait();
        //////    Console.ReadKey();
        //////}
        //////public async static Task M1Wrapper()
        //////{
        //////    await Task.Run(() => M1());
        //////}

        //////public static void M1()
        //////{
        //////    for (int i = 0; i < 10; i++)
        //////    {
        //////        Console.WriteLine(" From method M1: i=" + i);
        //////    }
        //////}

    }
}
