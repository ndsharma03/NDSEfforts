using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{
    class ThreadWithMultipleParam
    {
        //We can you Lambda expression to call any multi Param method;
        //We can pass param in Start method;it must be single param type of 'Object'.
        /*
        public static void Main()
        {
            Thread t1 = new Thread(()=>Add(4,5));
            t1.Start(); 

            // other work in Main()

            Console.WriteLine(" ThreadWithMultipleParam.Main : Other work in Main method");
            
            Console.ReadLine();
        }
        */
        private static void Add(int a, int b)
        {
            Thread.Sleep(2000);
            Console.WriteLine(" Sum of a+b= " + (a + b));
        }
    }
}
