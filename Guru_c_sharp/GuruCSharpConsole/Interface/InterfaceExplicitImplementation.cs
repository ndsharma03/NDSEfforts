using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.Interface
{
    /// <summary>
    /// We have two interface which has method with same name, class will implement interface explicitly
    /// </summary>

    interface ILaptop
    {
        void Display();
    }
    interface IMobile
    {
        void Display();
    }
    class InterfaceExplicitImplementation:ILaptop,IMobile
    {

        //As we are implementing interfaces explicitly and so we will be able to access methods only through interface reference as we are commenting common definition so we are not able to acess these method through class reference.
       
        //*** Note ***: We can not apply public modifier, if we are implementing interface member explicitly.
        void IMobile.Display()
        {
            Console.WriteLine("Mobile.Display");
        }

         void ILaptop.Display()
        {
            Console.WriteLine("Laptop.Display");
        }
       //public void Display()
       //{
       //    Console.WriteLine("Display from class");
       //}
    }

    //*******Note *********** :: public class can't inherit from internal class (or any class whose accessibility is less then public class.

     class DerivedInterfaceExplicitImplementation : InterfaceExplicitImplementation
    {
    }
    public class Tester
    {


        //public static void Main()
        //{
        //    IMobile objIMobile = new DerivedInterfaceExplicitImplementation();
        //    objIMobile.Display();// it will print "Mobile.Display".

        //    ILaptop objILaptop = new DerivedInterfaceExplicitImplementation();
        //    objILaptop.Display();// it will print "Laptop.Display".
        //    Console.Read();
        //}

    }
}
