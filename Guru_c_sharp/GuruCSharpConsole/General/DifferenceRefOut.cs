using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{

    //this program shows difference between refrence and out keyword. 
   
    class DifferenceRefOut
    {

        //we have to initialize ref veriable before use.
        // out is unidirectional means we can not pass value to method through out param to the method, before using out veriable in method we must initialize it inside method.
        // we can not create overloaded methods by only ref and out param.compiler will throw an error. 
       
        
        //public static void Main()
        //{
        //    DifferenceRefOut obj = new DifferenceRefOut();
           
        //   //== ref parameter==
        //    int k = 6;
        //    obj.m1(ref k);

            
        //    //=================
        //    //==out paramter===
        //    int m ;
        //    obj.m1( out m,8);
        //    Console.WriteLine(m);
        //    //=================
        //    Console.Read();
        //}

        public void m1(ref int a)
        {
            Console.WriteLine("inside m1="+a);
            a = 9;

        }
        public void m1(out int b, int k)
        {
            b = 10;
            Console.WriteLine("inside m1=" +b);
            b = 10; }
    }
}
