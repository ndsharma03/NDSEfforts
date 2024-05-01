using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharpConsole.Threads
{
    class DependentAwait
    {
        //public static void Main()
        //{
        //    Task<int> t = M1Wrapper();
        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.Write("Some operation " + i);
        //    }
        //    Console.WriteLine("Final Result=" + t.Result);
        //    Console.ReadKey();
        //}
        public async static Task<int> M1Wrapper()
        {
            Task<int> t1 = Task.Run<int>(() => { Thread.Sleep(10000);  return M1(4, 5); });
            await t1;
            Task<int> t2 = Task.Run<int>(() => M1(t1.Result,5));
            await t2;
            Task<int> t3 = Task.Run<int>(() => M1(t2.Result,5));
            return await t3;
         
        }
        public static int M1(int a,int b)
        {
            return a + b;
        }
        
    }
}
