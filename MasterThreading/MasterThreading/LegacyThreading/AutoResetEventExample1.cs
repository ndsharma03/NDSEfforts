using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{
    // This example shows how to use AutoResetEvent object to syncronize threads.
    // Main thread should wait to complete Thread1,This wait logic we can achive through AutoResetEvent.
    
    class AutoResetEventExample1
    {
        private static AutoResetEvent objAuto1 = new AutoResetEvent(false);
        /*
        public static void Main()
        {
            Thread thread1 = new Thread(ThreadMethod);
            thread1.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" Main : Value of i= " + i);
            }
            objAuto1.WaitOne(); //Main thread will wait for singal from Threadmethod.

            Console.WriteLine("All work has been finshed by Main and WorkerThread..");
            Console.WriteLine("Gooood Bye !!!");

        }
         * */
        public static void ThreadMethod()
        {
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("ThreadMehtod : Value of i= " + i);
                Thread.Sleep(500);
            }
            objAuto1.Set();
        }
    }
}
