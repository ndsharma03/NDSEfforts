using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{
   public class ExtensionTest
    {
       //public static void Main()
       //{
       //     ClsTest c=new ClsTest();
       //      string ss=  c.M2ExtensionMethod("Niranjan");
       //     Console.WriteLine(ss);
       //    Console.Read();
       //}
    }

   class ClsTest
   {
       public void M1()
       {
           Console.WriteLine("Hello");

       }
   }
   static class CLSTestExtension
   {
       public static string M2ExtensionMethod(this ClsTest clstest,string s)
       {
           return "Extended " + s;
       }
   }
}
