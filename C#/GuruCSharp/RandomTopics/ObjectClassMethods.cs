using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.RandomTopics
{

    interface IA
    {
        void Beta(int name);
    }
    class TestA :IA
    {
       public int id { get; set; } = 1;
        public string Name { get; set; } = "Niranjan";

        public override bool Equals(object obja)
        {
            TestA obj = (TestA)obja;
            return id == obj.id && Name == obj.Name;
        }
        public void Beta(int test) // In case of interface method implementation it's necessary to give same name of method but paramter name may be different only type should be same.
        {
            Console.WriteLine(" Implementating interface method with differenct method name and param name");
        }
    }
    class ObjectClassMethods
    {
        //public static void Main1()
        //{
        //    TestA a = new TestA();
        //    TestA a1 = new TestA();
        //    Console.WriteLine(a.Equals(a1));
        //    Console.WriteLine(a == a1);
        //    Console.Read();
        //}
        
    }
}
