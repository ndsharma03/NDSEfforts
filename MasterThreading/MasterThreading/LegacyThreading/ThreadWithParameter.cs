using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{
    class ThreadWithParameter
    {
        /*
        public static void Main()
        {
            Thread t1 = new Thread(ThreadMethod);
            t1.Start(100); //We can pass param in Start method;it must be single param type of 'Object'.

            // other work in Main()
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" ThreadWithParameter.Main Method, Value of i= " + i);
            }
            Console.ReadLine();
        }
        */
        private static void ThreadMethod( object n)
        {
            for (int i = 0; i < (int)n; i++)
            {
                Console.WriteLine(" ThreadWithParameter.Thread Method, Value of i= " + i);
            }
        }
    }
}
