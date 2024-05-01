using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading
{
    //SemaphoreSlim -> allow only to specified threads to access resource.
    class SemaphoreTest
    {
        // Note : In this program all members are static becasue I want to use them in Main method.

        static SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(5);

        public static void EnterInClub()
        {
            if(_semaphoreSlim.CurrentCount>5)
            Console.WriteLine("Thread {0} Trying to enter in night club  " + Thread.CurrentThread.ManagedThreadId+"\n");
            _semaphoreSlim.Wait(); // Synchronization Area start
            
            Console.WriteLine("Thread {0} Enjoying in night club   " + Thread.CurrentThread.ManagedThreadId + "\n");
            Thread.Sleep(2000);
            Console.WriteLine("Thread {0} Leaving in night club  " + Thread.CurrentThread.ManagedThreadId + "\n");
           
            _semaphoreSlim.Release();//Syncronization Area end.
            
        }

        //public static void Main()
        //{
        //    for (int i = 0; i < 15; i++)
        //    {
        //        new Thread(EnterInClub).Start();
        //    }

        //    Console.ReadKey();
        //}
    }
}
