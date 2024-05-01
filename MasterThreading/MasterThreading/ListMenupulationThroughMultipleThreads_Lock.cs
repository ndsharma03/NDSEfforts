using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading
{
    /// <summary>
    /// This example shows the synchronization of list operation add and iterate. we can not modify collection while iterating so lock is necessary to syncronize
    /// </summary>

    class ListMenupulationThroughMultipleThreads_Lock
    {
        Mutex m = new Mutex();
        List<String> _list = new List<string>();
        private static object locker = new object();

        // adding items to list through multiple thread 
        public void Add(string item)
        {
            lock (locker) //here we can also use _list for lock.
            {
                item = item + Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine("Lock Applied by=" + Thread.CurrentThread.ManagedThreadId + "********************\n");
                _list.Add(item);
            }
               
        }
        // iterating through list of item  through multiple thread while other thread also tried to add items in list. so used syncronization construct -Lock.
        public void GetAllListItem()
        {
            lock (locker)
            {
                Console.WriteLine("Priniting by thread =" + Thread.CurrentThread.ManagedThreadId + "********************");
                foreach (string s in _list)
                {
                    Console.WriteLine(s);
                }
                } 
           
            Console.WriteLine("****************End Thread********************");
        }

        public void AddnShow(string item)
        {
            Add(item);
            GetAllListItem();
        }
    }

    public class LockTester
    {
        //public static void Main()
        //{
        //    ListMenupulationThroughMultipleThreads_Lock ltmt = new ListMenupulationThroughMultipleThreads_Lock();

        //    for(int i=0;i<10;i++)
        //    {
        //        int k=i;
        //        Thread t=new Thread(() => ltmt.AddnShow("hello" ));
        //        t.Start();
        //        //t.Join();
        //     }
        //    Console.ReadKey();
        //}

    }
}
