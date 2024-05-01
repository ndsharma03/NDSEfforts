using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {

        class A
        {
            static A()
            {

            }
            public static void m1()
            {
                Console.WriteLine("Static M!");
            }
            public void InstanceA()
            {
                Console.WriteLine("InstanceA");

            }
        }
        class B : A
        {
            public new static void m1()
            {
                Console.WriteLine("Providing new definition in B!");
            }
            public void InstanceB()
            {
                Console.WriteLine("Instance B");
               
            }
        }

        public static void Main()
        {
            A a = new A();
            a.InstanceA();
            A.m1();
            B.m1(); // Static method also inherited.
            Console.WriteLine();

            Console.Read();
        }

        #region Async test
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(" Main running in Thread {0}", Thread.CurrentThread.ManagedThreadId);
        //    Action<object> longRunnningTask = (object param) =>
        //      {
        //          Console.WriteLine(" Long running task running in Thread {0}", Thread.CurrentThread.ManagedThreadId);
        //          for(int i = 0; i < (int)param; i++)
        //          {
        //              Console.WriteLine(" Long Running Task, Value of I={0}", i);
        //          }
        //      };


        //    //1st way to create and run Task
        //    Task t = new Task(longRunnningTask, 50);
        //    t.Start();

        //    //2nd Way to create and run Task
        //    Task.Factory.StartNew(longRunnningTask, 50);// we can pass param via StartNew() method.

        //    //3rd way to create and Run Task.
        //    Task.Run(()=>longRunnningTask(51)); // We can't pass parameter direct via run method but alternate way I used.

        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine(" Value of i form Main() i={0}", i);
        //    }
        //    Console.Read();
        //}
        #endregion
    }
}
