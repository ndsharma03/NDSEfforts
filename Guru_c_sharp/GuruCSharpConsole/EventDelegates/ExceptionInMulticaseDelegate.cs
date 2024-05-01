using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// To handle exception in multicase delegate you need to call GetInvocationList().
namespace GuruCSharpConsole.EventDelegates
{
    delegate void Operation();
    class ExceptionInMulticaseDelegate
    {
        static Operation operation;

        //public static void Main()
        //{
        //    operation += add;
        //    operation += Sub;
        //    operation += Mul;
        //    /*This sttement will break application execution. becasue Sub methods throws an exception.*/
        //    //try
        //    //{

        //    //    operation();
        //    //}
        //    //catch (Exception e) { }
        //    foreach (Operation op in operation.GetInvocationList())
        //    {
        //        try
        //        {
        //            op();
        //        }
        //        catch (Exception ex) { }
        //    }
        //    Console.ReadLine();
        //}

        public static void add()
        {
            Console.WriteLine("Asdd");
        }
        public static void Sub()
        {
           throw new Exception();
        }
        public static void Mul()
        {
            Console.WriteLine("Mul");
        }
    }
}
