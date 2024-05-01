using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.RandomTopics
{
    class FinallyBlock
    {
         public static void Main()
        {
            Console.WriteLine("Result = "+CheckReturnInFinallyBlock(5, 0));
            Console.ReadLine();
        }
        public static int CheckReturnInFinallyBlock(int a, int b)
        {

             return 0;

        }
    }
}
