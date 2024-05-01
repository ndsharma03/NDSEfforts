using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{

    /// <summary>
    /// Same example as 'ThreadWithMultiParamAndReturnValueByMultipleThreads' but here i will try to use 'join' instead of IsAlive.
    /// </summary>
    class ThreadWithMultiParamAndReturnValueByMultipleThreadsUsingJoin
    {
       /*
        public static void Main()
        {

        

            int[] resultFromThread = new int[5];
            Thread[] threadArray = new Thread[5]{
                
                new Thread(()=> resultFromThread[0]=Add(4,5)),
                new Thread(()=> resultFromThread[1]=Add(5,5)),
                new Thread(()=> resultFromThread[2]=Add(6,5)),
                new Thread(()=> resultFromThread[3]=Add(7,5)),
                new Thread(()=> resultFromThread[4]=Add(8,5)),
            };



            foreach (var t in threadArray)
            {
                t.Start();
            }




            Console.WriteLine(" ThreadWithMultipleParam.Main : Other work in Main method");

            
                foreach (var t in threadArray)
                {
                    t.Join();
                    Console.WriteLine("Joining Thread " + t.ManagedThreadId);
                }
                
            


            Console.WriteLine(" Printing Result of Threads :\n ");

            foreach (var i in resultFromThread)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        */
        private static int Add(int a, int b)
        {
            Thread.Sleep(8000);
            return (a + b);
        }
    }
}
