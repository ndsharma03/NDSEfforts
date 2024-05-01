using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading
{
    class ThreadSafe
    {
        List<string> _list = new List<string>();
       public  void Test()
        {
            lock (_list)
            {
                _list.Add("Item 1");
            }
        }
       public void Print()
       {
           Console.Write("Items in List=" + _list.Count);
       }
    }
   public  class ThreadUnsafe
    {
      static int a = 1, b = 1;

      
      public  static void Go()
        {
            try
            {
                Console.WriteLine("Running=" + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Value of a={0} and b={1}", a, b);
                if (b != 0)
                {
                    Console.WriteLine(a / b);

                } b = 0;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            
        }
    }
   
   class LockSampleTester
   {

       //public static void Main()
       // {
       //    ThreadSafe ts = new ThreadSafe();

       //    for (int i = 0; i < 20; i++)
       //    {
       //        //Statrting 15 threads
       //        new Thread(ts.Test).Start();
              
       //    }
           
       //    ts.Print();
       //    Console.ReadKey();
       //}
   }
}
