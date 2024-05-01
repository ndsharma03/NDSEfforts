using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading
{
    class ListManipulationThroughMultipleThread_Mutex
    {
        Mutex _mutex = new Mutex();
        List<String> _list = new List<string>();
       
        // adding items to list through multiple thread 
        public void Add(string item)
        {
                _mutex.WaitOne();

                item = item + Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine("Lock Applied by=" + Thread.CurrentThread.ManagedThreadId + "********************\n");
                _list.Add(item);

                _mutex.ReleaseMutex();

        }
        // iterating through list of item  through multiple thread while other thread also tried to add items in list. so used syncronization construct -Mutex.
        public void GetAllListItem()
        {
                _mutex.WaitOne();

                Console.WriteLine("Priniting by thread =" + Thread.CurrentThread.ManagedThreadId + "********************");
                foreach (string s in _list)
                {
                    Console.WriteLine(s);
                }
                _mutex.ReleaseMutex();

            Console.WriteLine("****************End Thread********************");
        }

        public void AddnShow(string item)
        {
            Add(item);
            GetAllListItem();
        }
    }

    public class MutexTester
    {
        //public static void Main()
        //{
        //    ListMenupulationThroughMultipleThreads_Lock ltmt = new ListMenupulationThroughMultipleThreads_Lock();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        int k = i;
        //        Thread t = new Thread(() => ltmt.AddnShow("hello"));
        //        t.Start();
        //        //t.Join();
        //    }
        //    Console.ReadKey();
        //}

    }
}

