using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{   
    //First of all in .net framework 4.0 and later version we have multiple ways to pass multiple paramters to thread
    //and get value back using inbuilt constructs provided by .net framework like (BackgroundWorker,IAsyncResult,TPL,Async and Await)
    //But here we will try to do the same thing using legacy Thread class.
    
    class ThreadWithMultiParamAndReturnValue
    {
        /*
        public static void Main()
        {
            
            // First Approach
            // We can use lambda expression and get result in Global variable
            //generally this approach is known as Closure.

            int resultFromThread = 0;
            Thread t1 = new Thread(()=> resultFromThread=Add(4,5));
            t1.Start();
            
            // here we will get resultFromThread=0 becasue it's long running operation 
            //and we are not waiting for it to be finished.
            //so,default value of var resultFromThread=0 will be printed
            Console.WriteLine(" Result from Thread= " + resultFromThread);
            
            
            Console.WriteLine(" ThreadWithMultipleParam.Main : Other work in Main method");
            t1.Join(); // Main thread will be blocked until t1 finshed. so we will get accurate result in resultFromThread here.

            Console.WriteLine(" Result from Thread= " + resultFromThread); // resultFromThread=9
            Console.ReadLine();
        }
         * */
        
        private static int Add(int a, int b)
        {
            Thread.Sleep(4000);
            return (a + b);
        }
    }
}
