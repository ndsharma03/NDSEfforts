using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Value types are always 'passed by value' to method.

    class CallByValueCallByReference
    {
        //public static void Main(){
        //    int temp=10;
        //    Console.WriteLine( " Value of temp before 'ChangeValueType()' method call = " +temp);
        //    ChangeValueType(temp);
            
        //    Console.WriteLine("\n Value of temp after 'ChangeValueType()' method call = " + temp);
        //    Console.WriteLine("\n If you want to change value of 'temp' from method ChangeValueType()");
        //    Console.WriteLine(" You have to pass 'temp'  to ChangeValueType() 'by reference'.");
            
        //    ChangeValueType(ref temp);
            
        //    Console.WriteLine("\n Value of temp after passing reference to 'ChangeValueType()' method = " + temp);
        //    Console.ReadLine();
        //}
        public static void ChangeValueType(int t)
        {
            t = 15;
        }
        public static void ChangeValueType(ref int t)
        {
            t = 15;
        }
    }

}
