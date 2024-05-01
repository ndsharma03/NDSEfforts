using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    //very simple implementation of Adapter pattern.
    public interface IPrint
    {
        // Method used to Print value on Console
        void Print(object value);
    }
    public class ConsoleAdapter :  IPrint
    {
        public void Print(object value)
        {
            if (value != null)
               Console.WriteLine(value); // Console class is Adaptee (i.e. class providing desired functionality) 
                                         //it's static so calling desired method directly by class name otherwise we have to create object of desired(Adaptee)class here.
        }
    }

    class AdapterPatternTest
    {
        //public static void Main()
        //{
        //    IPrint printer =new ConsoleAdapter();
        //    printer.Print("Hello from Adapter!!");
        //    Console.Read();// just to see output on console.
        //}
    }
}
