using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{

    // same example as ThreadWithMultiParamAndReturnValue but here I will invoke add method from multiple threads to see impact.
    class ThreadWithMultiParamAndReturnValueByMultipleThreads
    {
        /*
        public static void Main()
        {
            
            

            int [] resultFromThread = new int[5];
            Thread [] threadArray = new Thread[5]{
                
                new Thread(()=> resultFromThread[0]=Add(4,5)),
                new Thread(()=> resultFromThread[1]=Add(5,5)),
                new Thread(()=> resultFromThread[2]=Add(6,5)),
                new Thread(()=> resultFromThread[3]=Add(7,5)),
                new Thread(()=> resultFromThread[4]=Add(8,5)),
            };



            foreach(var t in threadArray)
            {
                t.Start();
            }
            
           
            
            
            Console.WriteLine(" ThreadWithMultipleParam.Main : Other work in Main method");
            
            // below code is used to check weather any thread is still running if yes we need to wait until it finishes
            // otherwise we will not get result from it.

            bool isAnyThreadRunning=true;

            while (isAnyThreadRunning) //continueous while loop, it will stop if isAnyThreadRunning will be false.
            { 
                int noOfThreadStrillRunning=0;
                
                foreach(var t in threadArray) 
                {
                    if (t.IsAlive) // checking if any thread is still running via IsAlive property on each thread. if yes, increment 'noOfThreadStrillRunning'
                   {
                       noOfThreadStrillRunning++;
                   }
                }
                if (noOfThreadStrillRunning == 0)// if noOfThreadStrillRunning==0 means all thread has been finished so, we can print result.
                {
                    isAnyThreadRunning=false;
                }
            }


            Console.WriteLine(" Printing Result of Threads :\n " ); 
            
            foreach(var i in resultFromThread)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
         
        */
        private static int Add(int a, int b)
        {
            Thread.Sleep(4000);
            return (a + b);
        }
    }
}
