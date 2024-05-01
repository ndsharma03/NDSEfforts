using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General.virtualOverride2
{
    public class A
    {
        public virtual void SampleMethod()
        {
            Console.WriteLine("Virtual Method in A");
        }

    }
    public class B : A
    {
        public override void SampleMethod()  // here also method defined as virtual
        {
            Console.WriteLine(" Virtual Method in B");
        }
    }
    public class C : B
    {
        public virtual void SampleMethod()
        {
            Console.WriteLine(" Virtual Method  in C");
        }
    }

    public class D : C
    {
        public override void SampleMethod()
        {
            Console.WriteLine(" Virtual Method  in D");
        }
    }
    class VirtualOverride2
    {
        /*
        public static void Main()
        {
            //With reference of A
            Console.WriteLine("****** With reference of A ***************");
            A a = new B();
            a.SampleMethod(); // b's implentation as overrided in B.
            
            a = new C();
            a.SampleMethod(); // b's implementation becsue hided in C(by virtual).
            
            a = new D();
            a.SampleMethod(); //B's implentation.

            //With reference of B
            Console.WriteLine("****** With reference of B ***************");
            
            B b = new B();
            b.SampleMethod(); //b's impementation

            b = new C();
            b.SampleMethod(); //b's implementation

            b = new D();
            b.SampleMethod(); //b's implementation

            //With reference of C
            Console.WriteLine("****** With reference of C ***************");
            
            C c = new C();
            c.SampleMethod();// c's impementation

            c = new D();
            c.SampleMethod(); //D's implementation

            //With reference of D
            Console.WriteLine("****** With reference of D ***************");

            D d = new D();
            d.SampleMethod();
            
            
            Console.Read();
        }*/
    }
}
