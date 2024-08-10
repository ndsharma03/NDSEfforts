using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace InterviewPractice
{
    internal class Program
    {

      static void IndicesNRange()
        {
                    string[] words =new[]  {
                                        // index from start     index from end
                                        "first",    // 0                    ^10
                                        "second",   // 1                    ^9
                                        "third",    // 2                    ^8
                                        "fourth",   // 3                    ^7
                                        "fifth",    // 4                    ^6
                                        "sixth",    // 5                    ^5
                                        "seventh",  // 6                    ^4
                                        "eighth",   // 7                    ^3
                                        "ninth",    // 8                    ^2
                                        "tenth"     // 9                    ^1
                    };

           var temp= words.Select((s, i) => new { first=s, key=i }).ToDictionary(key=>key, f=>f.key);
        }
        public static void GeneralLinQ1()
        {
            // below expression produces cross join

            var cards = from rank in "A23456789TJQK"
                        from suits in "CDHS"
                        from deck in Enumerable.Range(1, 2)
                        select $"{rank} {suits} {{deck}}";
            foreach(var v in cards)
            {
                Console.WriteLine(v);
            }            
            

        }
        static void Main(string[] args)
        {
            A a = new A();
            a.M1();
            a.M1Ext("Niranjan");

            a = null;
            //a.M1();//Exception
            a.M1Ext("Harsh"); //No Exception for Extension methods.

            Console.ReadLine();
            
          // GeneralLinQ1();
            //IndicesNRange();

       // FibboRecursive(0, 1, 1, 6);
            //Fib(6);
            //MergeAndSortTwoUnsortedArray();
            //WorkingWithHashSet();
            //DuplicateInAnArray();
            //DuplicateInAnArrayusingLinQ();
            //FindCountOfCharactersinAString();
            //LinQOprations();

            // SingletonTest
            //var method = () =>
            //{
            //    SingaltonEx obj = SingaltonEx.Instance;
            //    Thread.Sleep(500);
            //    obj.Print("Hello from Singleton!");
            //};

            //for (int i = 0; i < 10; i++)
            //{
            //    Parallel.Invoke(method, method, method, method, method, method, method, method, method, method);
            //}

        }
        public static void Fib(int n)
        {
            //0,1,1,2,3,5
            int i = 0, j=1, result=0;
            Console.WriteLine(i);
            Console.WriteLine(j);
            for (int k = 2; k < n; k++)
            {
                result = i + j;
                i = j;
                j = result;
                Console.WriteLine(result);
            }
        }
        public static void FibboRecursive(int a,int b,int cnt,int len)
        {
            if (cnt<=len)
            {
                Console.WriteLine(a);
                Console.WriteLine($"{a} {b} {cnt} {len}");
                FibboRecursive(b, a + b, cnt+1, len);
                
            }

           
        }
        public static void MergeAndSortTwoUnsortedArray()
        {
            //int min = 1;= K[0] = 1;
            //        =2   k[1]=2
            //        =2  k[2]=

            int [] a = { 101,99,500 };
            int [] b = { 50,300,700 };
            int[] c = new int[a.Length+b.Length];
            int temp = 0;

            int i = 0, j = 0, k = 0;
            while (i<a.Length)
            {
                c[k++] = a[i++];

            }
            while (j < b.Length)
            {
                c[k++] = b[j++];
            }
            //Sorting array C.
            for(int cnt = 0; cnt < c.Length; cnt++)
            {
                for(int n=cnt+1; n<c.Length; n++)
                {
                    if (c[cnt] >= c[n])
                    {
                        (c[cnt], c[n]) = (c[n], c[cnt]);
                    }
                }
            }
            Console.WriteLine(string.Join(",", c));
        }
        public static void WorkingWithHashSet()
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 1, 5, 6 };
            set.TryGetValue(3, out int val);

            HashSet<int> subset = new() { 1, 4, 6 };

            Console.WriteLine("Is Proper subset"+ set.IsProperSupersetOf(subset));
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