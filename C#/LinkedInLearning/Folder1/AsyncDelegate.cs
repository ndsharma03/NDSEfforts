using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedInLearning.Folder1
{
    class AsyncDelegate
    {
        public void Dowork() // Returning Void
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("Finsished Work!! by Thread : " + Thread.CurrentThread.ManagedThreadId);
            }
        }
        public int DoworkInt() // Returnning Void
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("Finsished Work!! by Thread : " + Thread.CurrentThread.ManagedThreadId);
            }

            return 200;
        }
    }
    public delegate void WorkHandler();

    public class Program
    {
        public static void Main1() // Test : Do Work Returning Void()
        {
            AsyncDelegate objAsync = new AsyncDelegate();

            WorkHandler _handler = objAsync.Dowork;

            IAsyncResult ar = _handler.BeginInvoke(null, null);

            Thread.Sleep(2000);
            Console.WriteLine(" Doing some work from Main method by Thread :" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" Doing some work from Main method by Thread :" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" Doing some work from Main method by Thread :" + Thread.CurrentThread.ManagedThreadId);

            _handler.EndInvoke(ar);

            Console.WriteLine(" Doing some work from Main method");

            Console.Read();

        }

        public static void Main2() // Test : Do Work Returning int
        {
            AsyncDelegate objAsync = new AsyncDelegate();
            Func<int> _handler = new Func<int>(objAsync.DoworkInt);

            //WorkHandler _handler = objAsync.DoworkInt;

            IAsyncResult ar = _handler.BeginInvoke(Callback, _handler);

            Thread.Sleep(2000);
            Console.WriteLine(" Doing some work from Main method by Thread :" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" Doing some work from Main method by Thread :" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" Doing some work from Main method by Thread :" + Thread.CurrentThread.ManagedThreadId);


            Console.WriteLine("Waiting for deleagte to finish...");


           Console.Read();

        }

        public static void Callback(IAsyncResult ar)
        {
            var _hndler = (Func<int>)ar.AsyncState;

            Console.WriteLine("Result from delegate method " + _hndler.EndInvoke(ar));

        }
    }
}
