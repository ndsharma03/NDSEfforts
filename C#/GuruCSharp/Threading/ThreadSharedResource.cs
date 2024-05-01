using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharp.Threading
{
    class ThreadSharedResource
    {
        static int  sharedResource = 0;

        public static void IncrementSharedResource()
        {
            sharedResource++;

        }
        //public static void Main()
        //{
        //    for(int i = 0; i < 50; i++)
        //    {
        //        Thread t = new Thread(IncrementSharedResource);
        //        t.Start();
        //    }
        //    Thread.Sleep(3000);
        //    Console.WriteLine(sharedResource);
        //    Console.Read();
        //}
    }
}
