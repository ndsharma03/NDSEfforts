using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{

    // 3 Threads will statred and then will wait for signal from Main method.
    // print one no. and then again will go to wait state and wait for signal from Main method.

    class AutoResetEvent_MultipleThreadControling
    {
        
        private static AutoResetEvent objAuto1 = new AutoResetEvent(false);
        //private static AutoResetEvent objAuto2 = new AutoResetEvent(false);
       /*
        public static void Main()
        {
            Thread thread1 = new Thread(ThreadMethod1);
            thread1.Start();
            Thread thread2 = new Thread(ThreadMethod2);
            thread2.Start();
            Thread thread3 = new Thread(ThreadMethod3);
            thread3.Start();

            for(int i=0;i<30;i++){
                objAuto1.Set();
                Thread.Sleep(100);
            }
            
            Console.WriteLine("All work has been finshed by Main and WorkerThread..");
            Console.WriteLine("Gooood Bye !!!");
            Console.Read();
        }
       */
        public static void ThreadMethod1()
        {
            for (int i = 1; i < 10; i++)
            {
                objAuto1.WaitOne();
                Console.WriteLine("ThreadMethod1 : " + i);
                Thread.Sleep(100);
                
            }
            
        }
        public static void ThreadMethod2()
        {
            for (int i = 1; i < 10; i++)
            {
                objAuto1.WaitOne();
                Console.WriteLine("ThreadMethod2 : " + i);
                Thread.Sleep(100);
               
            }
            
        }
        public static void ThreadMethod3()
        {
            for (int i = 1; i < 10; i++)
            {
               objAuto1.WaitOne();
                Console.WriteLine("ThreadMethod3 : " + i);
                Thread.Sleep(100);
                
            }
            
        }
    }
}
