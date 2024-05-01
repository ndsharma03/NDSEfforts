using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharpConsole.Threads
{
    class AsyncAwaitWithIntReturnType
    {


        //public static void Main()
        //{
        //    Task<int> res = ComplexWrapper(5, 56);
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("valur i=" + i);
        //    }
        //    Console.WriteLine("Result=" + res.Result);

        //    Console.ReadKey();
        //}
        //public static void m1()
        //{
        
        //}


        public static async Task<int> ComplexWrapper(int a, int b)
        {
            int result=await Task.Run<int>(() => ComplexOperation(a, b));
            return result;
        }
        public static int ComplexOperation(int a, int b)
        {
            Thread.Sleep(3000);
            return a + b;
        }
    }
}
