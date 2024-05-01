using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
namespace GuruCSharpConsole.Threads
{
    
    class AsyncException
    {
        //public static void Main()
        //{
        //    Console.WriteLine("Calling Async method...");
        //    Task<double> result = DivideAsync(9, 0);
            
        //        Console.WriteLine("Division Result=" + result.Result);
           
        //}

        public async static Task<double> DivideAsync(int a, int b)
        {
           Double result= await Task.Run<double>(()=>Divide(a,b));
           return result;
        }
        public static double Divide(int a, int b)
        {
            double r = 0;
            try
            {
                Thread.Sleep(5000);
                r = a / b;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            return r;
        }
    }
}
