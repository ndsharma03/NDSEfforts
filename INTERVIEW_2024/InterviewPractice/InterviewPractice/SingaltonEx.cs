using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class SingaltonEx
    {
        private int privateVar = 0;
        private static SingaltonEx obj;
        private int count = 0;
        private SingaltonEx()
        {
            count++;
        }
        public static SingaltonEx Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new SingaltonEx();
                }
                return obj;
            }
        }
        public void Print(string message) { Console.WriteLine(  message);
            Console.WriteLine("No of instances of SingaltonEx=" +count);
        }
       
    }

    
}