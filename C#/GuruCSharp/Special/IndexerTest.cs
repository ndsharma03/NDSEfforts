using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.Special
{
    public class Person
    {
        int age;
        string name;

        public string this[string propertyname]
        {
            get
            {
                if (nameof(name) == propertyname.ToLower())
                {
                    return name;
                }
                return string.Empty;
            }
            set
            {
                if (nameof(name) == propertyname.ToLower())
                {
                    name = value;
                }
               // return string.Empty;
            }
        }
       
        //public int this [string propertyname] //We can't define indexers with same parameter type
        //{
        //    get
        //    {
        //        if (nameof(age) == propertyname)
        //        {
        //            return age;
        //        }
        //        return 0;
        //    }
        //}

    }
    class OtherUseOfIndexer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public OtherUseOfIndexer()
        {
           // Orders = new List<Order>();
        }

        public Order this[int orderId]
        {
            get
            {
                return Orders.Where(x => x.OrderId == orderId).FirstOrDefault();
                    
             }
        }

    }

    public class Order
    {
        public int OrderId { get; set; }
        public string Tag { get; set; }
    }

    class IndexerTest
    {
        public static void Main1()
        {
            // USe 1:
            Person p = new Person();
            p["Name"] = "Niranjan";
            Console.WriteLine( "Value of Name property ="+p["Name"]);


            //Getting  order by orderid
            //Use 2:
            OtherUseOfIndexer obj = new OtherUseOfIndexer
            {
                Name = "First",
                Orders = new List<Order> { new Order { OrderId=1,Tag="Order1"},
                                            new Order{ OrderId=2 ,Tag="Order2"},
                                            new Order{OrderId=3,Tag="Order3"}
                 }
            };

            

            Console.WriteLine(obj[1].Tag);
            Console.WriteLine(obj[2].Tag);
            Console.Read();
            
        }
    }
}
