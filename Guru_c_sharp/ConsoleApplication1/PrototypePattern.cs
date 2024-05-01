using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Address
    {
        public string stret { get; set; }
    }
    class Customer
    {
        public string NAme { get; set; }
        public Address address { get; set; }
        public Customer Clone()
        {
            Customer c= (Customer)this.MemberwiseClone();
            return c;
        }

        class A
        {
            protected void m1() { Console.Write("A"); }

            public void K()
            {
                Console.Write("K");
            }
        }
        class B:A
        {
            public void M2()
            {
                Console.Write("B");

            }

            public void bm() { m1(); }
        }
        class C : B
        {
            public void M3()
            {
                Console.Write("C");
            }
            public void CM()
            {
                m1();
            }
        }

        //public static void Main()
        //{

        //    B b = new B();
        //    b.M2();
        //    A a = new A();
        //    C c = new C();
        //    a.K();
        //    b.bm();
        //    c.CM();
            
        //    //Customer c = new Customer();
        //    //Address s = new Address { stret = "ram society" };
        //    //c.address = s;
        //    //c.NAme = "Niranjan";
         
        //    //Customer c1 = c.Clone();
            

        //    //Console.Write(c.NAme + "          Address= " + c.address.stret);
        //    Console.Read();
        //}
    }
}
