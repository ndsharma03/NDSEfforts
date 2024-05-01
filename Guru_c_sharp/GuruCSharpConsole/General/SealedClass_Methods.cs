using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{

    class A
    {
        public virtual void Method1()
        {
            Console.WriteLine("A-->Method1");
        }
    }
    class B : A
    {
        public override void Method1()
        {
            Console.WriteLine("B-->Method1");
        }
    }
    class C : B
    {
        public override sealed void Method1()
        {
            Console.WriteLine("C-->Method1");
        }
    }
    class D : C
    {
        public new void Method1()  /* We cannot override sealed method but we can use new/virtual keyword*/
        {
            Console.WriteLine("D-->Method1");
        }


    }
    //class E : D
    //{
    //    public override void Method1()  /* We cannot override sealed method but we can use new keyword*/
    //    {
    //        Console.WriteLine("E-->Method1");
    //    }


    //}
    class SealedClass_Methods
    {
        //public static void Main()
        //{
        //    A a = new A();
        //    a.Method1();

        //    a = new B();
        //    a.Method1();

        //    a = new C();
        //    a.Method1();

        //    a = new D();
        //    a.Method1();

        //    //D d = new E();
        //    //d.Method1();
   

        //    Console.Read();
        //}
    }
}
