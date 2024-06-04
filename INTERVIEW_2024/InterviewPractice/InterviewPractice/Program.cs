using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace InterviewPractice
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //WorkingWithHashSet();
        //    //DuplicateInAnArray();
        //    //DuplicateInAnArrayusingLinQ();
        //    //FindCountOfCharactersinAString();
        //    //LinQOprations();

        //    // SingletonTest
        //    var method = () =>
        //    {
        //        SingaltonEx obj = SingaltonEx.Instance;
        //        Thread.Sleep(500);
        //        obj.Print("Hello from Singleton!");
        //    };

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Parallel.Invoke(method, method, method, method, method, method, method, method, method, method);
        //    }
           
        //}
        public static void WorkingWithHashSet()
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 1, 5, 6 };
            set.TryGetValue(3, out int val);

            HashSet<int> subset = new() { 1, 4, 6 };
            Console.WriteLine(  "Is Proper subset"+ set.IsProperSupersetOf(subset));
            Console.WriteLine("Is subset" + set.IsSupersetOf(subset));
            Console.WriteLine(val);
            foreach (var v in set)
            {
                Console.WriteLine(v);
            }

        }

        public static void FindCountOfCharactersinAString()
        {
            string str = "This is my program";
            var lst= str.GroupBy(x => x).Where(x=>x.Key!=' ').Select(x => new { Key= x.Key, Count=x.Count()}).ToList();
            foreach(var li in lst)
            {
                Console.WriteLine(li.Key +"="+li.Count);
            }
            //###### Witout LinQ
            Console.WriteLine( "Counting chanracter in a string without LINQ" );
            Dictionary<char,int> dic= new();
            foreach(char c in str)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else dic.Add(c, 1);
            }
            foreach(var item in dic) Console.WriteLine($"Prining counts of charecter{item.Key}-{item.Value}");
        }
        public static void DuplicateInAnArrayusingLinQ()
        {
            int[] arr = { 1, 2, 3, 5, 3, 6, 7 };
         var lst=   arr.GroupBy(x=>x).Where(x=>x.Count()>1).Select(x=>
            new
            {
                Key = x.Key,
                Count = x.Count()
            }).ToList();
            foreach(var i in lst)
            {
                Console.WriteLine(  $"Items in the list: {i.Key} -{i.Count}" );
            }
        }

       
        public static void DuplicateInAnArray()
        {
            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
            int[] arr = { 1, 2, 3, 5, 3, 6, 7 };
          
            for (int i=0;i<arr.Length; i++)
            {
                if (keyValuePairs.ContainsKey(arr[i]))
                {
                    keyValuePairs[arr[i]]++;
                }
                else
                {
                    keyValuePairs.Add(arr[i], 1);
                }
            }
            foreach (var kv in keyValuePairs)
            {
                Console.WriteLine(kv.Key + "--> " + kv.Value);
                if (kv.Value > 1)
                {
                    Console.WriteLine($" Fount duplicate {kv.Key} : count {kv.Value}");
                }
            }
        }

        public static void LinQOprations()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id=1,
                    Name="Amit",
                    Orders=new List<Order>{new Order { Id=1},new Order { Id=2} }
                },
                   new Customer
                {
                    Id=2,
                    Name="Sumit",
                    Orders=new List<Order>{new Order { Id=1}}
        },
                      new Customer
                {
                    Id=3,
                    Name="Prasanna",
                    Orders=new List<Order>{new Order { Id=8},new Order { Id=9},new Order { Id = 3 } }
                      }
            };

            #region "Select Many"
            var result = customers.Distinct().SelectMany(x => x.Orders);
            foreach(var o in result) Console.WriteLine($"Oreders found : {o.Id}");
            #endregion

            #region Finding element having min length
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Console.WriteLine("Finding element having min length");
            string[] countries = { "India", "USA", "UK" };

           var dicstr= countries.ToDictionary(x => x,e=>e.Length);

            var min = dicstr.Min(x => x.Value);
            foreach(var kv in dicstr)
            {
                if (kv.Value == min)
                {
                    Console.WriteLine($"The shortest country name {kv.Key} {kv.Value} ");
                }
            }
            int minCount = countries.Min(x => x.Length);
            int maxCount = countries.Max(x => x.Length);

            Console.WriteLine("The shortest country name has {0} characters", minCount);
            Console.WriteLine("The longest country name has {0} characters", maxCount);
        }
        #endregion

    

    }
        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<Order> Orders { get; set; }
        }
        class Order
        {
            public int Id { get; set; }
        }
    }