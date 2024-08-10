using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class A{   
        public void M1()=> Console.WriteLine(" hello");
               
    }

    public static class AEXtension    {        
        public static void M1Ext(this A obj, string name)=> Console.WriteLine("Hello " + name);

    }
}
