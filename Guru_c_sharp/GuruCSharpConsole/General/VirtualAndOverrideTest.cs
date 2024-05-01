using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General.BaseDerived
{
    /// <summary>
    /// abstract class can contains constructor.
    /// abstract member can not be virtual.
    /// we always need to override abstract member in derived class, otherwise error will be generate.
    /// if we are declaring a abstract member we must need to declare class as abstract.
    /// there is only one way to call base implementation of override member, create base reference and object.otherwise you always get derived implementation.
    /// </summary>


    public abstract class BaseClass
    {
        public static int StatTest()
        {
            return 0;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public BaseClass()
        {
            Name = "Amit";
            Address = "Pune";
        }
        //Absract method
        public abstract void AbstractMethodM1();  // we can not declare abstract method as virtual.
        
        //Virtual method
        public virtual void VirtualMethod()
        {
            Console.WriteLine("Base implementation");
        }

        
        
    }
    public class DerivedClass:BaseClass
    {
        public DerivedClass()
        {
            Name = "Niranjan";
            Address = "abd";
        }
        public void print()
        {
            Console.WriteLine(" Name={0} and Address ={1}", Name, Address);
        }
        public virtual void VirtualMethod() // here we are not overriding this virual method, so we will get base implementation if we are calling it through base reference.
        {
            Console.WriteLine("Derived implementation");
        }
        public override void AbstractMethodM1() // override keyword must
        {
            Console.WriteLine("Derived M1");
        }
    }
       
    
    class VirtualAndOverrideTest
        {
             //public static void Main()
             //{
             //    Console.WriteLine( DerivedClass.StatTest());//we can declare static method in abstract class
             //    DerivedClass d = new DerivedClass();

             //    d.print();
             //    d.VirtualMethod(); // derived implemetation as we are calling through derived reference.

             //  //   base reference
             //    BaseClass b = new DerivedClass(); 
             //    b.VirtualMethod(); // it will call base implemetation becasue it's not oveerided in derived class.
              
             //    Console.Read();
             //}
              
        }
    
}
