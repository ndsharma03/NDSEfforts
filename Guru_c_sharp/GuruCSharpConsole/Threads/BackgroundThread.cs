using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace GuruCSharpConsole.Threads
{
    class PriorityTest
    {

        

        /// <summary>
        /// Difference between Forgroung and background thread
        /// </summary>
        /// <param name="args"></param>
      /*  static void Main(string[] args)
        {
            Thread worker = new Thread(() => { Console.ReadLine(); });
       
            if (args.Length > 0) worker.IsBackground = true;
            worker.Start();

            Console.WriteLine("FRom Main Thread");
        }*/


        // This code show how to pass parameter to the thred and get value back from thread.
        static int Method1(string s)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Hello "+s + i);
                //Thread.Sleep(1000);
            }
            if(s=="World")
            {
                return 999;
            }
            else if (s == "a")
            {
                return 434;
            }
            else
            {
                return 545;
            }
        }
       
        //static void Main()
        //{

        //    int returnvalue=0;
        //    int returnvalur2 = 0;
        //    int returnvalue3 = 0;

        //    Thread t = new Thread(() => { returnvalue=Method1("World"); });
        //    t.Start();

        //    Thread t1 = new Thread(() => { returnvalur2 = Method1("a"); });
        //    t1.Start();

        //    Thread t2 = new Thread(() => { returnvalue3 = Method1("c"); });
        //    t2.Start();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(" Main Hello "+ i);
        //       // Thread.Sleep(1000);
        //    }

        //    // To Stop printing of veriable value if any thread is running.
        //    if (t1.IsAlive)
        //        t1.Join();
        //    if (t2.IsAlive)
        //        t2.Join();
        //    if (t.IsAlive) { t.Join(); }
        //    //
        //    //At this point all thread executed and return value set at respective veriable. 
            
        //    Console.Write(returnvalue);
        //    Console.Write(returnvalur2);
        //    Console.Write(returnvalue3);

        //    Console.ReadKey();
        //}
    }
}
