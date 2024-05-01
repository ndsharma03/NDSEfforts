using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharpConsole.Threads
{
    class MultipleAwaitTest
    {
        public static void Main()
        {
            Task t = M1Wrapper2();
            //Other Operation ....
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main i=" + i);
            }
            Console.ReadKey();
        }
        public async static Task M1Wrapper()
        {
            Task t1 = Task.Run(() => M1());
            Task t2 = Task.Run(() => M2());
            Task t3 = Task.Run(() => M3());
            await t1;
            await t2;
            await t3;
        }
        public async static Task M1Wrapper2()
        {
            Task t2= Task.Run(() => M1());
            //Task t2 = Task.Run(() => M2());
            //Task t3 = Task.Run(() => M3());
            //await t1;
            //await t2;
            //await t3;
            await t2;
        }
        public static void M1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Method M1: i=" + i);
            }
        }
        public static void M2()
        {            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Method M2: i=" + i);
            }
        }
        public static void M3()
        {           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Method M3: i=" + i);
            }
        }

    }
}
