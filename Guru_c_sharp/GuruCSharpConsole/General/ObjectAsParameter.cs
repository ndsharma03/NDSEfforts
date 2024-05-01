using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General1
{
    // This example shows that objects are also passed by value by default.

    class A
    {
        public int i { get; set; }
    }
    class ObjectAsParameterTest
    {
        //public static void Main()
        //{


        //    A a1 = new A { i = 6 };
        //    A a2 = new A { i = 8 };

        //    Swap(a1, a2); // will not swap a1 and a1. if we want to swap a1 and a2 need to pass it by ref.

        //    List<A> lst = new List<A> { a1, a2 };
        //    Add(lst);

        //    Console.WriteLine("Lst Count" + lst.Count);
        //    Console.WriteLine(" a1={0} , a2={1}", a1.i, a2.i);
        //    Console.Read();
        //}

        public static void Swap(ref A a, ref A b)
        {
            A temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(A a, A b)
        {
            // it will not make a1 and a2 null.
            //a = null;
            //b = null;
            // changes in content of object will reflect at both places
            a = b;
            b.i = 9;
        }

        /// <summary>
        /// Add will chnages the actual list.i.e. newly added item will be added to the actual list.
        /// </summary>
        /// <param name="lst"></param>
        public static void Add(List<A> lst)
        {
            // it will add new object of A to actual list
            lst.Add(new A { i = 44 });
        }

    }
}
