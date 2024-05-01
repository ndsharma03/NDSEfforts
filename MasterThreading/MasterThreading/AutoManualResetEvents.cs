using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MasterThreading
{

    // This example is used to print numbers alternatively from 2 Thread (one numeber from thread one then another number from thread2 and vice versa).
    class AutoManualResetEventsTester
    {
       static AutoResetEvent ae1 = new AutoResetEvent(false);
       static AutoResetEvent ae2 = new AutoResetEvent(false);
        public static void Method1()
        {
            for (int i = 0; i < 20; i++)
            {
                ae2.Set();
                Console.WriteLine("Method 1  " + i);
               
                Thread.Sleep(500);
                ae1.WaitOne();

                
               
            }
        }
        public static void Method2()
        {
            for (int i = 0; i < 20; i++)
            {
                ae1.Set();
                Console.WriteLine("Method 2  " + i);
                Thread.Sleep(500);
                ae2.WaitOne();
               
            }
        }
/*
        public static void Main()
        {
            new Thread(Method1).Start();
            new Thread(Method2).Start();
            Console.Read();
        }
        */

    }


}
