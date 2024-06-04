using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("Base Print:");
            Console.WriteLine($"Id={Id}, Name={Name}");
        }
    }
    public class Derived:Base
    {
        public int Salary { get; set; }
        public void Print()
        {
            Console.WriteLine("Derived Print");
            Console.WriteLine($"Id={base.Id}, Name={base.Name}, Salary={Salary}");
        }
    }
    internal class BaseDerivedRelationship
    {
        //public static void Main()
        //{
        //    Console.WriteLine(  "This example shows that when we are setting member via derived class base member already set.");
        //    Console.WriteLine("We are alreadt getting values for base memebers( Id and name) while setting this values for derived class");

        //    Base b = new Base { Id = 1, Name = "Base" };
        //    b.Print(); //Expected base method call

        //    Derived d = new Derived { Id=2,Name="Derived", Salary=3000};
        //    d.Print(); //Expected derived call

        //    Base bd = new Derived { Id = 3, Name = "Derived base", Salary = 5000 };
        //    bd.Print(); //Expected derived call but getting base impl.

        //}
    }
}
