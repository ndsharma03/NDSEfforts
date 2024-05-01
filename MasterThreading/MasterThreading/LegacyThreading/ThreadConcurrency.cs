using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{
    public class Printer
    {
        private object locker = new object();
        public void PrintNumbers()
        {
            
            lock(locker)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Thread " + Thread.CurrentThread.ManagedThreadId + " i= " + i);
                   // Thread.Sleep(50);
                }
            }
        }
    }
    class ThreadConcurrency
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("*****Synchronizing Threads *****\n");
        //    Printer p = new Printer();
        //    // Make 10 threads that are all pointing to the same
        //    // method on the same object.
        //    Thread[] threads = new Thread[10];
        //    for (int i = 0; i < 10; i++)
        //    {
        //        threads[i] =
        //        new Thread(new ThreadStart(p.PrintNumbers));
        //        threads[i].Name = string.Format("Worker thread #{0}", i);
        //    }
        //    // Now start each one.
        //    foreach (Thread t in threads)
        //        t.Start();
        //    Console.ReadLine();
        //}
    }
}
