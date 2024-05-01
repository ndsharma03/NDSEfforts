using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuruCSharpConsole.Threads
{

    /// <summary>
    /// Suppose you want to call a method asynchronously-> you need to create a wrapper method with Async keyword and use await and Task.Run() to run actual method inside it,
    /// and then finally it will return Task in main method. see below example:
    /// </summary>
   public  class AsyncAndAwait
    {
       //public static void Main()
       //{
       //    AsyncAndAwait awt = new AsyncAndAwait();
       //    var t =  awt.WrapperActualMethod();

       //    Console.WriteLine("Before Wait");

       //    for (int i = 0; i < 10; i++)
       //    {
       //        Console.WriteLine("Main i=" + i);
       //    }
       //    t.Wait();                           //If you will not use t.Wait() than no insertion operation will perform becasue main thread will exit.
       //    Console.WriteLine("After Wait");     //i.e. you need to use t.Wait() or t.Result to make your child thread operation to be completed.
       //    Console.WriteLine("Bye!!!");
       //    Console.ReadKey();

       //}

       //we need to put Async keyword before return type of method
       public async Task WrapperActualMethod()
       {
           await Task.Run(()=> ActualMethod());
           for (int i = 0; i < 10; i++)
           {
               Console.WriteLine("valur i=" + i);
           }
          
       }

       

       public void ActualMethod()
       {
           for (int i = 0; i < 100; i++)
           {
               Thread.Sleep(10);
               Console.WriteLine("Actual method" + i);
           }
//           string constr = @"User ID=sa;Password=sa;Data Source=NIRANJANS\SQLEXPRESS;Initial Catalog=ABCD;";

//           using (SqlConnection con = new SqlConnection(constr))
//           {
//               con.Open();
//               for (int i = 0; i < 100; i++)
//               {
//                   string empName = "Amit" + i;
//                   SqlCommand com = new SqlCommand(

//                   @"INSERT INTO [Employee]([FIRST_NAME],[LAST_NAME],[DEPARTMENT_ID],[SALARY])
//                             VALUES ('" + empName + "','Verma' ," + " 4," + "400" + i + ");", con);

//                   com.ExecuteNonQuery();
//               }
//               con.Close();
//           }
             
         }
       }

    }

  


   


