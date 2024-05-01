using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharp.Threading
{
    /// <summary>
    /// This example shows that how we can wrap thread method inside of a class and use it in thread.
    /// </summary>

    class ThreadMethodWrapper
    {
        int param1;
        int param2;
        public ThreadMethodWrapper(int param1, int param2)
        {
            this.param1 = param1;
            this.param2 = param2;
        }
        public void Add()
        {
            Thread.Sleep(15000);
            Console.WriteLine(" Sum of Param1 "+param1+" and Param2 "+param2+" =" + (param1 + param2));

        }
    }
        
    class ThreadMethodWrapperTest
    {
        /*
        public static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                ThreadMethodWrapper t = new ThreadMethodWrapper(i, 5);
                Thread thread = new Thread(t.Add);
                thread.Start();
                Console.Write(i + " -> ");
            }
            Console.Read();
        }
        */
    }
}
