using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.Tasks
{
    public class TaskBasics
    {
        public int LongRunningTask(int a, int b)
        {
            Thread.Sleep(5222);
            return a + b;
        }
        public double LongRunningTask1(int a, int b)
        {
            
            throw new Exception("errro!!!");
            
            return (double)(a - b);
        }

        //public static void Main()
        //{
        //    TaskBasics obj = new TaskBasics();
        //    try
        //    {
        //        Task<double> d;

        //        d = Task.Run<int>(() => obj.LongRunningTask(4, 5)).ContinueWith<double>((t1) => obj.LongRunningTask1(t1.Result, 4));

        //        for (int i = 0; i < 100; i++)
        //        {
        //            Console.WriteLine(i);
        //        }
        //        Console.Write("Result=" + d.Result);
        //    }
        //    catch (AggregateException ex)
        //    {
        //        foreach (Exception e in ex.InnerExceptions)
        //        {
        //            Console.Write(e.Message);
        //        }
        //    }
        //    Console.Read();

        //}
    }
}