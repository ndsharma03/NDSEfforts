using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{
    //Thread.CurrentThread.ManagedThreadId
    class CreateThread
    {
        /* Open this comment to run Main()
        public static void Main()
        {
            Thread t1 = new Thread(ThreadMethod);
            t1.Start(); //new thread will start and execute ThreadMethod();
            
            // other work in Main()
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" Main Method, Value of i= " + i);
            }
            Console.ReadLine();
        } 
         */

        private static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" Thread Method, Value of i= " + i);
            }
        }
    }
}
