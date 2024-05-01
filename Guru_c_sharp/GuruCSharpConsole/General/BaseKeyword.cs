using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{
    /// <summary>
    /// base keywork can be used any where i.e. either in constructor of derived class or methods in derived class.
    /// this keyword also can be used in constructor and methods of derived class but we cannot use this inside of static methods.
    /// </summary>
    public class ABase
    {
        public void Method1()
        {
            Console.WriteLine("From Base Method");
        }

    }
    public class ADerived : ABase
    {

        public ADerived():base() // this is only way by which we can call base constructor
        {
            base.Method1();
            
        }
        public void Method1()
        {
            base.Method1();                         //we can call base method in derived class.
            Console.WriteLine("From Derived Method");
            this.Method2();
        }
        public void Method2()
        {
            Console.WriteLine("Derived Method2");
        }
    }
    class BaseKeyword
    {
        //public static void Main()
        //{
        //    ABase ab = new ADerived();
        //    ab.Method1();// base method
        //    Console.ReadLine();

        //    ADerived d = new ADerived();
        //    d.Method1();// derived method
        //    Console.ReadLine();

            
        //}
    }
}
