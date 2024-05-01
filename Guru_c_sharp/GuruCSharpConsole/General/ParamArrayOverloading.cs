using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{
    class ParamArrayOverloading
    {
                //public static void Main()
                //{
                //    M1(5);// it will always calls single param methods.
                //    M1(new int[]{5,5});
                //    Console.Read();
                //}
        public static void M1(int a){
            Console.WriteLine(a);
        }
        public static void M1(params int[] b)
        {
            Console.WriteLine("params");
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
        }

    }
}
