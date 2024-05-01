using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IA
    {
         void m1();
    }
    public class derived:IA
    {
        public virtual void m1()
        {
            //Console.Write("base");
            
        }
        void IA.m1()
        {
            Console.Write("IA");
        }
    }
    public class derived1 : derived
    {
        public  override void m1()
        {
            Console.Write("derived");
        }
    }
    public class CLASS2
    {
        private int k = 3;

        public virtual void Add(int a)
        {
            Console.WriteLine((k + a).ToString()); 
        }
        public virtual void Sub(int b)
        {
            Console.WriteLine((k - b).ToString());

        }
    }

    public class CLASS3 : CLASS2
    {
        string name = "abc";
        int age = 35;
        public CLASS3(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override void Sub(int b)
        {
            Console.WriteLine((100 - b).ToString());
        }
        //public static void Main()
        //{
        //    //CLASS3 cls3 = new CLASS3("LLL",33);
        //    //CLASS3 cls4=new CLASS3("LLL",33);
        //    //Console.Write(object.Equals(cls3,cls4));
        //    IA d = new derived();
        //    d.m1();
            
        //  Console.Read(); 
            
        //}


        //public override bool Equals(object obj)
        //{
        //    if (this.name == ((CLASS3)obj).name && this.age == ((CLASS3)obj).age)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
   
}
