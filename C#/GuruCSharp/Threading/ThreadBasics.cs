using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharp.Threading
{
    class ThreadBasics
    {

        #region "Basics -Thread creation"

        //public static void Main()
        //{
        //    Console.WriteLine("Main Started..");

        //    Thread t = new Thread(LongRunningOperation);
        //    t.Start();

        //    for(int i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine("From Main i=" + i);
        //    }

        //    Console.WriteLine("Main Ended...");
        //    Console.Read();
        //}
        //public static void LongRunningOperation()
        //{
        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine("From LongRunningOperation i=" + i);
        //    }
        //}

        #endregion

        #region Parameterised Thread -- how to pass data to thread.
        
        // With the help of ParameterizedThreadStart delegate we can pass one parameter of type Object to Thread method; (Note : method should return void).
        public static void Main1() //***********************Rename to Main
        {
            Console.WriteLine(" Inside Main : This example demonstrate, how to create parameterised thread..");

            //1st Way :
            ParameterizedThreadStart threadStartDelegate = new ParameterizedThreadStart(Add);
            Thread threadParameterised = new Thread(threadStartDelegate);
            threadParameterised.Start(9);


            // 2nd way :

            Thread ParamThread = new Thread(Add);
            ParamThread.Start(4);

            //3rd way
            Thread t = new Thread(() => Add(5));
            t.Start();

            //  4th way:
            // We can create a new wrapper class which will contains thread method and params to thread. 
           
            /* for example 
             * 
             * class ThreadCreator{
             * int param1;
             * int param2;
             * Public ThreadCreator(int param1, int param2){
             *  this.param1=param1;
             *  this.param2=param2;
             *  }
             *  public void Add(){
             *  Console.WriteLine(" Sum of number's ="+(param1+param2));
             *  }
             *  }
             *  ThreadCreator t=new ThreadCreator(4,5);
             *  Thread t=new Thread(t.add);
             *  t.Start();
             * 
             * */

            Console.WriteLine(" Main Ended.!!");
            Console.Read();
        }
        public static void Add (object obj)
        {
            Thread.Sleep(5000);
            int sum = ((int)obj + 5);
            Console.WriteLine( "adding 5 to given no "+obj+ ", sum is=" +sum);
        }
        #endregion
    }
}
