using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.Structure
{

    public class Address
    {
        public string address { get; set; }
    }
   public  struct MyStruct
    {
        int age;
        string name;
        Address aa;

        

        public MyStruct(int age, string name, Address aa)
        {
            this.aa = aa;
            this.age = age;
            this.name = name;
            
        }
        public MyStruct(int age)
        {
            this.age = age;
            this.name = "name";
            this.aa = new Address() { address = "temp" };
        }
      
      public Address Addresss { get { return aa; } set { aa = value; } }

      public  string Name
        {
            get
            {
                return name;
            }
            set 
            { 
                 name = value; 
            }
        }
      public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }

    class StructureTest
    {
            //public static void Main()
            //{
            //    MyStruct s = new MyStruct(44, "nirnajna", new Address { address = "Pune" });

            //    Console.WriteLine("Age={0} ,Name={1} ,Address={2}", s.Age, s.Name, s.Addresss.address);

            //    MyStruct s1 = s;
            //    s1.Age = 22;
            //    s1.Name = "Manoj";
            //    s1.Addresss.address = "Mumbai"; //new Address { address = "Mumbai" };
            //    Console.WriteLine("Age={0} ,Name={1} ,Address={2}", s1.Age, s1.Name,s1.Addresss.address);
            //    Console.Read();
            //}
    }
}
