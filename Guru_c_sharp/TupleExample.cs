using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruAdvanceCSharp.Tuples
{
    class TupleExample
    {
        public Tuple<Int32, Int32> methodReturnsMultipleValues()
        {

             //Write code whatever you want.
            // Note: Item1, Item2...are readonly property, we can't set value with these property
            // we must need to pass values in Tuple constructor.
            return new Tuple<int, int>(5, 6);
        }

        public int TuplesAsInput(Tuple<int,int> t)
        {
            return t.Item1 + t.Item2;
        }
    }

    class Tester
    {
        public static void Main()
        {
            TupleExample te = new TupleExample();
            Tuple<int,int> result=te.methodReturnsMultipleValues();

           int intResult= te.TuplesAsInput(Tuple.Create<int, int>(5, 6));// instead of passing param in constructor we can use Tuple.Create() to create tuple.
           
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);

            Console.WriteLine("Result from TuplesAsInput"+intResult);

            Console.Read();

        }
    }
}
