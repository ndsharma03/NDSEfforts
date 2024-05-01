using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharp.RandomTopics
{
    class Revision21062019
    {
        //public static void Main()
        //{
            
        //    AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        //    try
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.Write(  finbonacci(10));
        //        Console.Read();

        //        //    var task=    Task.Factory.StartNew(() =>
        //        //    {
        //        //        Thread.Sleep(2000);
        //        //        Console.WriteLine("Hello");
        //        //        throw new Exception("Exception raised");
        //        //    });
        //        //task.Wait();
        //    }
        //    catch (AggregateException ex)
        //    {
        //        Console.WriteLine("Exception catched");
        //    }
            
        //    Console.Read();
        //}

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(" UNHANDLED EXCEPTION !!!!!!!!!!!!!!!!!!!!!!");
        }

        // 0 1 1 2 3 5 8 12
        public static int finbonacci(int n)
        {
            try
            {
                int a = 0;
                int b = 1;
                int fib = 1;

                if (n == 0)
                    return 1;

                fib = finbonacci(n) + finbonacci(n - 1);
                Console.WriteLine(fib);
                return fib;
            }catch(Exception ex)
            {
                Console.WriteLine("StackOverflow");
            }
            return 0;
            //fib = a + b;
            //a = b;
            //b = fib;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //for(int i = 1; i < n; i++)
            //{
            //    fib = a + b;
            //    a = b;
            //    b = fib;
            //    Console.WriteLine(fib);
            //}


        }
    }
}
