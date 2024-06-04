using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
namespace InterviewPractice
{
    internal class HackerRankTest
    {
        public static void Main()
        {
            // for (int i = 1; i < 31; i++) FizzBuzz2(i);
            //ListOperationsHackerRank();
            //MinMaxOf4Numbers();


            //foreach(var i in  GetDigits(125).Reverse()) Console.Write(i +" ");
            // Console.WriteLine();
            
            Console.WriteLine(CalculateFactorial(30));


        }

        //below code uses BigInteger to store extemely large number 
        static BigInteger CalculateFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static void extraLongFactorials(int n)
        {
            decimal result = 1;

            decimal factorail(int n)
            {
                Console.WriteLine("--> "+n);
                if (n == 0) return 1;

                result =(decimal) n * factorail(n - 1);
                return result;
            }

            Console.WriteLine(factorail(n));
        }
        public static IEnumerable<int> GetDigits(int number)
        {
            int src = number;
            int temp = 0;
            while (src > 0)
            {
                temp=src % 10;
                src = src / 10;
                yield return temp;
            }
          

        }
        public static void FizzBuzz(int n)
        {
            if (n % 15 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if(n % 3 == 0){
                Console.WriteLine("Fizz ");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine( n);
            }
        }
        public static void FizzBuzz2(int n)
        {
            string str = string.Empty;
            if (n % 3 == 0)
            {
                str += "Fizz";
               
            }
            if (n % 5 == 0) {
                str += "Buzz";
              
            }
            if(string.IsNullOrEmpty(str)) 
            { Console.WriteLine(n); 
            }
            else
            {
                Console.WriteLine(str);
            }
        }

        public static void ListOperationsHackerRank()
        {


            var result = Employee.GetSampleEmployees().GroupBy(x => x.Company);


           // var dic=result.ToDictionary(x => x.Key);
            var diction= result.ToDictionary(x => x.Key, y => y.Average(x => x.Age));
            foreach(var v in diction)
            {
                Console.WriteLine(v.Key + " -->" + v.Value);
            }
        }

        public static void Fake()
        {
            string s = "abc";
            IEnumerable<string> enm = new List<string>();
            Dictionary<int, string> dic = new();
            enm.Count();
      



        }
        public static  void MinMaxOf4Numbers()
        {
            List<int> lst= new(){ 1,2,3,4, 5 };
            List<long> resultLst = new List<long>();
            for (int i = 0; i < lst.Count; i++)
            {
                int item = lst[i];
                // Console.WriteLine(lst.Where(x => x != item).Select(x => x.ToString()).Aggregate((x, y) =>  x+","+y));
                //long sum = lst.Where(x => x != item).Sum(x=>Convert.ToInt64(x));
                long sum = 0;
                for(int j = 0; j < lst.Count; j++)
                {
                    if (i != j)
                    {
                        sum += lst[j];
                        Console.Write(lst[j] + ",");
                    }
                }
                Console.WriteLine();
                resultLst.Add(sum);
                Console.WriteLine(sum);
            }
            Console.Write(resultLst.Min());
            Console.Write(" "+ resultLst.Max());
        }

    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int Age { get; set; }

        // Constructor
        public Employee(string firstName, string lastName, string company, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            Age = age;
        }

        // Sample data
        public static Employee[] GetSampleEmployees()
        {
            return new Employee[]
            {
            new Employee("John", "Doe", "ABC Corp", 30),
                new Employee("Sumit", "Sharma", "ABC Corp", 32),
            new Employee("Jane", "Smith", "XYZ Ltd", 28),
            new Employee("Michael", "Johnson", "Tech Solutions", 35),
             new Employee("Niranjan", "Sharma", "Tech Solutions", 43),
                 new Employee("Chetan", "Sharma", "Tech Solutions", 42),

            };
        }
        public static void miniMaxSum(List<int> arr)
        {
            if (arr.Min() < 1 || arr.Max() > 1000000000)
                throw new Exception("Invalid Arguments");

            List<long> result = new();
            for (int i = 0; i < arr.Count(); i++)
            {
                long sum = 0;
                for (int j = 0; j < arr.Count(); j++)
                {
                    if (i != j)
                    {
                        sum += arr[j];
                    }
                }
                result.Add(sum);

            }
            Console.WriteLine($"{result.Min()} {result.Max()}");
        }
    }
}
