using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication1
{

    /// <summary>
    /// 8 threads are calling M1 method and lock is used to make it thread safe so, value of i will be printed only once.
    /// </summary>
    class Thereading
    {
        static int i = 0;
        private static object locker = new object();
        //public static void Main()
        //{
            
        //   Thread[] t =new[]{ new Thread(M1),new Thread(M1),new Thread(M1),new Thread(M1),new Thread(M1),new Thread(M1),new Thread(M1),new Thread(M1),new Thread(M1)};

        //   t[0].Start();
        //   t[1].Start();
        //   t[2].Start();
        //   t[3].Start();
        //   t[4].Start();
        //   t[5].Start();
        //   t[6].Start();
        //   t[7].Start();

        //     //for (int i = 0; i < 100; i++)
        //     //{
        //     //    Console.WriteLine("main running" + i);
        //     //}
        //    Console.Read();
        //}
    
        public static void M1()
        {
            lock (locker)
            {
                if (i == 0)
                {
                    Console.WriteLine("value of i" + i);
                    i = 1;
                }
            }
        }
    }


}
