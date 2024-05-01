using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        //public static void Main()
        //{

        //}
        public static string Get(int input)
        {
            string val = string.Empty;
            if (input % 3 == 0)
            {
                val += "Fizz";
            }
            if (input % 5 == 0)
            {
                val += "Buzz";
            }
            if (string.IsNullOrEmpty(val))
            {
                return input.ToString();
            }
            return val;
        }
    }
}
