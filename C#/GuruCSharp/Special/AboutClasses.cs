using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.Special
{
    #region MethodOverloadingTest
    /// <summary>
    /// This example show impact of 
    /// </summary>
    class MethodOverloadingTest
    {
        //When order of paramter work during method overloading
        // Note :Return type is not part of method signature.
        //i.e. if parater type of methods are same and only return type is diffrent, it will not work.

        public int Method1(int a, string s)
        {
            Console.WriteLine(a);
            return a;
        }
        //public string Method1(int b, string k) //Will not compile as paramter types are same as method 1
        //{
        //    Console.WriteLine(b);
        //    return b;
        //}

        public int Method1(string s,int a) //Will work as parameter orders are different.
        {
            Console.WriteLine(a);
            return a;
        }

        // Test ::2
        public void Method2(int a,int b)
        {
            Console.WriteLine("addition of a and b =" + a + b);
        }

        //public void Method2(int b, int c) //Will not work
        //{
        //    Console.WriteLine("addition of a and b =" + b + c);
        //}

        // Conclusion: if the method paramters have differnt type and their order is diffent then it will work 
        // if the method parameter are same type and just change in their names it will not work (as commented code).

        //public static void Main1() // Change name to Run code
        //{
        //    MethodOverloadingTest obj = new MethodOverloadingTest();
        //    obj.Method1(3, "first");
        //    obj.Method1("Second",2);
        //    Console.ReadLine();
        //}
    }
    #endregion
}
