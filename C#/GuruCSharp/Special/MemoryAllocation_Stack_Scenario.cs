using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.Special
{
    using System;

    struct PairOfInts
    {
        static int counter = 0;

        public int a;
        public int b;

        internal PairOfInts(int x, int y)
        {
            a = x;
            b = y;
            counter++;
        }
    }

    class Test
    {
        PairOfInts pair;
        string name;

        Test(PairOfInts p, string s, int x)
        {
            pair = p;
            name = s;
            pair.a += x;
        }

        //static void Main()
        //{
        //    PairOfInts z = new PairOfInts(1, 2);
        //    Test t1 = new Test(z, "first", 1);
        //    Test t2 = new Test(z, "second", 2);
        //    Test t3 = null;
        //    Test t4 = t1;
        //    // XXX

        //    Console.WriteLine(" t1==> a={0} b={1} name={2}", t1.pair.a, t1.pair.b, t1.name);
        //    Console.WriteLine(" t2==> a={0} b={1} name={2}", t2.pair.a, t2.pair.b, t2.name);
        //    Console.WriteLine(" t4==> a={0} b={1} name={2}", t4.pair.a, t4.pair.b, t4.name);
        //    Console.Read();
        //}
    }
   
}
