using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading.LegacyThreading
{
    
    /// <summary>
    /// Foreground thread prevent app domain to unload until it finishes it's work
    /// i.e. In below example you will see message "Main method is going to finish ..." and still no. are being printed on screen.
    /// if it's Background thread you might not see any no. on screen as main thread will  print "Main method is going.." 
    /// and finished immediately so, background thread will be killed by CLR and unload App Domain.
    /// </summary>
    class ForegroundAndBackgroundThreads
    {
       /*
        public static void Main()
        {
            Console.WriteLine(" Main method started ...");
            Thread t = new Thread(ThreadMethod);
           // t.IsBackground = true; // To declare thread as Background Thread
            t.Start();
            Console.WriteLine(" Main method is going to finish ...");
        }
        */
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" ThreadMethod : i= " + i);
                Thread.Sleep(500);
            }
        }
    }
}
