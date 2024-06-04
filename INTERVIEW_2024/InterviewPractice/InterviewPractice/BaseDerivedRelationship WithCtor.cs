using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice1
{
    public class Base
    {
        public Base(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Base() { }
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
        public Derived() { }
        public Derived(int id, string name, int salary)//:base(id,name)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
        public int Salary { get; set; }
        public virtual  void Print()
        {
            Console.WriteLine("Derived Print");
            Console.WriteLine($"Id={base.Id}, Name={base.Name}, Salary={Salary}");
        }
    }
    internal class BaseDerivedRelationship
    {
        //public static void Main()
        //{
        //    Console.WriteLine("This example shows that call the base class contructor from derived class ctor is only required if base class has no default constructor");
        //    Console.WriteLine("Comment default base ctor and see the impact.");

        //    Base b = new Base(1, "Base");
        //    b.Print(); //Expected base method call

        //    Derived d = new Derived(2, "Derived", 3000);
        //    d.Print(); //Expected derived call

        //    Base bd = new Derived(3, "Derived base", 5000);
        //    bd.Print(); //Expected derived call but getting base impl.

        //    IEnumerable<Base> ienum = new List<Base>();
         

        //    // Some differenent example 

        //       // Base b1 = new Base() { Id = 1, Name = "base1" };
        //       // Base b2 = new Base() { Id =2, Name = "base2" };
        //       // Base b3 = new Base() { Id = 3, Name = "base3" };
        //       // List<Base> lst = new List<Base> { b1, b2, b3, b1 };
        //       // Base b4 = new Base { Id = 4, Name = "base4" };
        //       // PRintList(lst);

        //       // var findfirst= lst.Find(x => x.Id == 9);
        //       //// var firstfid = lst.First(x => x.Id == 9);//exception
        //       // var firstOrdefalttest = lst.FirstOrDefault(x => x.Id == 90);
        //       // var singleOrdefaulttest = lst.SingleOrDefault(x => x.Id == 90);// exception only if found more than 1 element.
        //       // var singleTest = lst.Single(x => x.Id == 90);//exception if not found also if found duplicate.
        //       // findfirst = b4; //it will not affect list item
        //       // PRintList(lst);
            
        //       // lst[0] = b4; // now lost[0] will be b4.
        //       // PRintList(lst);


        //    //void PRintList(List<Base> lst)
        //    //{
        //    //    foreach(Base b in lst) Console.WriteLine(   b.Id +" -"+ b.Name);
        //    //}

        //    //Output:
        //    //1 - base1
        //    //2 - base2
        //    //3 - base3

        //    //1 - base1
        //    //2 - base2
        //    //3 - base3

        //    //4 - base4
        //    //2 - base2
        //    //3 - base3
        //}
    }
}
