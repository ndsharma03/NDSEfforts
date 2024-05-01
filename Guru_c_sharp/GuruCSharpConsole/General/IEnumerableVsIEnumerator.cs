using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{
    class IEnumerableVsIEnumerator
    {
        //public static void Main()
        //{
        //    IEnumerable<int> lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //    m1(lst.GetEnumerator());
        //    Console.ReadLine();
        //}
        public static void m1(IEnumerator<int> lst1)
        {
            while(lst1.MoveNext())
            {
                Console.WriteLine(" Value of i from m1 " + lst1.Current);
                if (lst1.Current == 5)
                {
                    m2(lst1);
                }
            }
        }
        public static void m2(IEnumerator<int> lst1)
        {
            while (lst1.MoveNext())
            {
                Console.WriteLine(" Value of i from m2 " + lst1.Current);
                
            }
        }
    }
}
