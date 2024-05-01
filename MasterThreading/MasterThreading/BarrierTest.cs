using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasterThreading
{
    class BarrierTest
    {
        static Barrier _barrier = new Barrier(3);
        
          static void Main()
          {

              new Thread(Speak).Start();
              new Thread(Speak).Start();
              new Thread(Speak).Start();

              Console.WriteLine(" From Main Thread");
              Console.ReadLine();
          }
        
        static void Speak()
        {
            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(500);
                Console.Write(i + " ");
                _barrier.SignalAndWait();
            }
        }
    }
}
