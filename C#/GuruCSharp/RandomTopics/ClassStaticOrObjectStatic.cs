using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.RandomTopics
{

    public class Emp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetName()
        {
            return FirstName + LastName;
        }
    }

    class EMPWrapper
    {
        public static Emp Employee = new Emp { FirstName = "Static Niranjan", LastName = "Static Sharma" };
           
    }
    class ClassStaticOrObjectStatic
    {
      
        //public static void Main()
        //{
        //    Emp obj = new Emp { FirstName = "Niranjan", LastName = "Sharma" };

        //    EMPWrapper.Employee = obj;          //Assigning new object to EMPWrapper.Employee
        //    Console.WriteLine(EMPWrapper.Employee.GetName());
        //    EMPWrapper.Employee = null;         //Assigning null to EMPWrapper.Employee
        //    Console.WriteLine(obj.GetName());   // Still obj is accessible and not null.
        //    Console.Read();
        //}
    }
}
