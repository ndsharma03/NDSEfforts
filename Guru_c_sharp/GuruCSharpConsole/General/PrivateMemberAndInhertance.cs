using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{

    //This class contain private field with public property.
    public class BaseClass
    {
        private int _age = 0;
        public int Age { get { return _age; } set { _age = value; } }

    }

    // It shows that private variables are also copied to derived class but they are not accessible in derived class.
    class DerivedClass : BaseClass
    {
        public void Print()
        {
            Age = 44; // you are able to access property becasue its public, and to work it field _age should be present in derived class. but you can't access _age directly
          
            Console.Write("Age=" + Age);
        }
    }
    class Tester
    {
        //public static void Main()
        //{
        //    DerivedClass d = new DerivedClass();
        //    d.Print();
        //    Console.Read();
        //}
    }
}
