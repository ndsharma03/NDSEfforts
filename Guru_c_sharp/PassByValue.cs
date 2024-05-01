using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Customer
    {
        public string FirstName { get; set; } public string LastName { get; set; } public int Id { get; set; }
    }
    class PassByValue
    {
        // In this case any chnages to customer object local to method. it will not reflect out side ChnageObject() as
        // local copy of 'cust1' will point to another 'Customer' object.(i.e. refrence are not sasme)
        public void ChangeObjetc(Customer cust1)  
        {
            Customer customer2 = new Customer();
            customer2.Id = 123;
            customer2.FirstName = "Niranjan";
            customer2.LastName = "Sharma";
            Console.WriteLine("*********** Value of Customer object inside Method *********");
            Print(customer2);
            cust1 = customer2;
        }
        public static void Print(Customer c)
        {
            Console.WriteLine("Id ={0}", c.Id);
            Console.WriteLine(c.FirstName);
            Console.WriteLine(c.LastName);
            Console.WriteLine("**********************************************");
        }
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 44;
            customer1.FirstName = "Ajay";
            customer1.LastName = "Kumar";
            Print(customer1);
            PassByValue p = new PassByValue();
            p.ChangeObjetc(customer1);
            Print(customer1);
            Console.ReadLine();
        }

        public void ChangeObjetc1(Customer cust1) // in this case properties of customer object will be change.
        {
            cust1.Id = 222;
            cust1.FirstName = "FirstNameChanged";
            cust1.LastName = "LastNameChanged";

        }



   
    }
}
