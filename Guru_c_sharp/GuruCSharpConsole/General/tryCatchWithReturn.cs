using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{
    /// <summary>
    /// Conclusion finally block will always execute, but it will not will not executed in case of StackOverflow Exception,
    /// thread.Abort() or power falure.
    /// </summary>
    class TryCatchWithReturn
    {
        //public static void Main()
        //{
        //    Method1(5, 4);
        //    Console.Read();
        //}

        public static int RecursiveMethod (int s,int l){

            return RecursiveMethod(4, 5);
    }
        public static int Method1(int a, int b)
        {
            try
            {
                //RecursiveMethod(5,5);        // finally will not executed in case of StackOverflow exception. 
               // Thread.CurrentThread.Abort(); // it will also not execute in case of Thread.Abort.
                 return a + b;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                Console.WriteLine("finally executed");
            }
        }
    }
}
