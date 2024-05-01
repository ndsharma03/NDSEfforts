using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.RandomTopics
{
    #region My implementation
    class A
    {
        public virtual void Mehtod1()
        {
            Console.WriteLine("Method1 of Class A");
        }
    }

    class DerivedA : A
    {
        public override void Mehtod1()
        {
            Console.WriteLine("Method1 of Derived A");
        }
    }
    class MethodOveridingAndNew
    {
        //public static void Main()
        //{
        //    A a = new A();
        //    a.Mehtod1();

        //    DerivedA da = new DerivedA();
        //    da.Mehtod1();

        //    A baseRef = new DerivedA();
        //    baseRef.Mehtod1();

        //    Console.Read();
        //}
    }

    #endregion

    #region MSDN

    class Car
    {
        public void DescribeCar()
        {
            System.Console.WriteLine("Four wheels and an engine.");
            ShowDetails();
        }

        public virtual void ShowDetails()
        {
            System.Console.WriteLine("Standard transportation.");
        }
    }

    // Define the derived classes.  

    // Class ConvertibleCar uses the new modifier to acknowledge that ShowDetails  
    // hides the base class method.  
    class ConvertibleCar : Car
    {
        //public void DescribeCar()  // If I will open this code then both method of this class will be called by it's object.
        //{
        //    System.Console.WriteLine("ConvertibleCar-->Four wheels and an engine.");
        //    ShowDetails();
        //}
        public new void ShowDetails()
        {
            System.Console.WriteLine("A roof that opens up.");
        }
    }

    // Class Minivan uses the override modifier to specify that ShowDetails  
    // extends the base class method.  
    class Minivan : Car
    {
        public override void ShowDetails()
        {
            System.Console.WriteLine("Carries seven people.");
        }
    }
    class Program {
        //public static void Main1()
        //{
        //    System.Console.WriteLine("\nTestCars1");
        //    System.Console.WriteLine("----------");

        //    Car car1 = new Car();
        //    car1.DescribeCar();
        //    System.Console.WriteLine("----------");

        //    // Notice the output from this test case. The new modifier is  
        //    // used in the definition of ShowDetails in the ConvertibleCar  
        //    // class.    

        //    ConvertibleCar car2 = new ConvertibleCar();
        //    car2.DescribeCar(); // Base Version will be called and as base version calls ShowDetails()
        //                        //but it's not overriden by derived class so, base version of ShowDetail will be called.
        //    System.Console.WriteLine("----------");

        //    Minivan car3 = new Minivan();
        //    car3.DescribeCar(); // As ShowDetails() is overridden by Minivan; so derived version will be called.
        //    System.Console.WriteLine("----------");
        //    Console.Read();
        //}
    }
}
    #endregion

