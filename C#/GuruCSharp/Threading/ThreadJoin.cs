using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharp.Threading
{
    class ThreadJoin
    {
        //public static void Main()
        //{
        //    Console.WriteLine("Main Started..");
        //    Thread t = new Thread(LongRunningOperation);
        //    t.Start();
        //    Console.WriteLine("Waiting for Thread to finish..");
        //    t.Join();
        //    Console.WriteLine("\n Main ended...");
        //    Console.ReadLine();

        //}
        public static void LongRunningOperation()
        {
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.Write(i);
            }
        }
    }
}
