using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.RandomTopics
{
    class BaseClass
    {
        protected int Add(int a ,int b)
        {
            return a + b;
        }
        protected void AddWrapper()
        {
           Console.WriteLine( Add(5, 9));
        }
    }
    class DerivedClass : BaseClass
    {
        public void m1()
        {
            int k = Add(4, 5);
            Console.WriteLine("Calling BaseClass's protected methods via Wrapper method m1()");
            AddWrapper();
        }
     }

    public class Tester
    {
        //public static void Main()
        //{
        //    BaseClass obj1 = new BaseClass();
        //    // not able to call Add method via BaseClass object.
        //    DerivedClass obj2 = new DerivedClass();
        //    obj2.m1();
        //    Console.Read();

        //}
    }
}
