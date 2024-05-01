using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{

    // Thread 1 and Thread 2 will execute alternatively.
    //1 number will be printed from Thread1 then it wil be wait for Signal from Thread2.
    //Thread2 will print one number and then it will wait for signal from Thread1.

    class AutoResetEvent_AlternateThreadExecution
    {
        private static AutoResetEvent objAuto1 = new AutoResetEvent(false);
        private static AutoResetEvent objAuto2 = new AutoResetEvent(false);
       /*
        public static void Main()
        {
            Thread thread1 = new Thread(ThreadMethod1);
            thread1.Start();
            Thread thread2 = new Thread(ThreadMethod2);
            thread2.Start();
           

            Console.WriteLine("All work has been finshed by Main and WorkerThread..");
            Console.WriteLine("Gooood Bye !!!");

        }
        */
        public static void ThreadMethod1()
        {
            for (int i = 1; i < 10; i++)
            {
                objAuto1.Set();
                Console.WriteLine("ThreadMethod1 : " + i);
                Thread.Sleep(500);
                objAuto2.WaitOne();
            }
            
        }
        public static void ThreadMethod2()
        {
            for (int i = 1; i < 10; i++)
            {
                objAuto2.Set();
                Console.WriteLine("ThreadMethod2 : " + i);
                Thread.Sleep(500);
                objAuto1.WaitOne();
            }
            
        }
    }
}
