using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharp.DataStructure
{
    class ConcurrentDictionary
    {
       static volatile ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();
        //static void Main(string[] args)
        //{

            

        //    Task t1 = Task.Factory.StartNew(() =>
        //    {
        //        for (int i = 0; i < 100; ++i)
        //        {
        //            dictionary.TryAdd(i.ToString(), i.ToString());
        //            Thread.Sleep(100);
        //            Console.WriteLine("Adding " +dictionary.Count);
                    
        //        }
        //    });
        //    Console.WriteLine("Before T2 Start Dictionary count :" + dictionary.Count);

        //    //######## NOT WORKING BECASUSE OF CAPTURED VARIABLE
        //    Task t2 = Task.Factory.StartNew(() =>
        //    {

        //        Thread.Sleep(300);
        //        foreach (var item in dictionary)
        //        {
        //            Thread.Sleep(250);
        //            Console.WriteLine(item.Key + "-" + item.Value);

        //            //Console.WriteLine("Iterating " + dictionary.Count);
        //            //dictionary.TryGetValue(item, out string val);
        //            //Console.WriteLine(val);
        //            //Console.WriteLine(Thread.CurrentThread.ThreadState);
        //        }



        //    });

        //    try
        //    {
        //        t1.Wait();
        //        Console.WriteLine("Coming out of T1's waitignstate");
        //        t2.Wait();
        //        Console.WriteLine("Coming out of T2's waitignstate");

        //    }
        //    catch (AggregateException ex) // No exception
        //    {
        //        Console.WriteLine(ex.Flatten().Message);
        //    }

        //    Console.Read();
        //}
      

    }
}
