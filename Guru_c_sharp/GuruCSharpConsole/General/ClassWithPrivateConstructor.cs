using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{
    // summary : we can inherite from a class which has private constructor if it also has other parameterised constructor and derived class used that paramterised constructor.

    class ClassWithPrivateConstructor
    {
        public int[] ak = new int[4];
        
        private ClassWithPrivateConstructor() {
       
        }
       
        public ClassWithPrivateConstructor(int k) { Console.Write("value passed to paramterised constructor=" + k); }
    }

    class DerivedOfPrivateConstructorClass : ClassWithPrivateConstructor
    {
        public DerivedOfPrivateConstructorClass():base(5)
        {
            ak = new int[10];
            
        }
        
        //public static void Main()
        //{
        //    DerivedOfPrivateConstructorClass obj = new DerivedOfPrivateConstructorClass();
        //    Console.Read();
        //}
    }
}
