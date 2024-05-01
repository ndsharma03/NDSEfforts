using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //* Interface member : we must have to declare as public.

    //Interface member : are not virtual by default.

    // abstract methods are virtual by default.

    /*we can define any no. of constructors in abstract class but if we define any parameterised constructor then we also need to define non parameterised constructor,otherwise 
    we specifically need to call parameterised constructor in derived class.*/

    //Access modifier are not alllowed in static constructor.
    // Static member can not mark as virtual , override ,abstract.
    // we can not implement interface member as static.
    //explicitly implemented interface member by default private.

    interface IP
    {
        void k1();
        
    }
   
   public abstract class B : IP
    {

      public static string name = "dfd";
       static B()
       {
           name = "B";
       }
       public B() { }
       public B(string s) { }
       public  virtual void k1() 
        {
            Console.WriteLine("K1");
        }
       public abstract void k2();
      
    }

    class C : B
    {
        public override void k1()
        {
            Console.WriteLine("K1");
        }
        public override void k2() { Console.WriteLine("K2"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IP p = new C();
            p.k1();

            Console.WriteLine(C.name);
            Console.Read();
        }
    }
}
