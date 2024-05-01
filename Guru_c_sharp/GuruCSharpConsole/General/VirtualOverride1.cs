using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General.virtualOverride1
{

    public class A
    {
        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual Method in A");
        }
             
    }
    public class B : A
    {
        public virtual void VirtualMethod()  // here also method defined as virtual
        {
            Console.WriteLine(" Virtual Method in B");
        }
    }
    public class C : B
    {
        public new void VirtualMethod()
        {
            Console.WriteLine(" Virtual Method  in C");
        }
    }

    //class D : C
    //{
    //    public override void VirtualMethod()
    //    {
    //        Console.WriteLine(" Virtual Method  in D");
    //    }
    //}


    class sealedTest
    {/*
        public static void Main()
        {
            

            A a = new C();
            B b = new C();
            C c = new C();

            a.VirtualMethod(); // a's implementation becaseu not overrided in B.
            b.VirtualMethod(); //b's implementation 
            c.VirtualMethod(); //c's implementation

            A a1 = new B();
            a1.VirtualMethod();// a's implemetation.

          
            Console.Read();
        }
      * */
    }
}
