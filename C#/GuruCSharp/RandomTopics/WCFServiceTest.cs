using GuruCSharp.MyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GuruCSharp.RandomTopics
{
    class WCFServiceTest
    {
        public static async Task<string> AsyncCall(Service1Client client)
        {
            var s= await client.GetMessageFromAAsync();
            return s.Message;
        }
        //static  void Main()
        //{
        //    try
        //    {
        //        Service1Client client = new Service1Client();
        //        var credential = client.ClientCredentials.Windows;

        //        //client.GetData(0);
        //        //Console.WriteLine(client.GetData1("Dummy"));

        //        var tasks = AsyncCall(client);

        //        Console.WriteLine("Please wait..");
        //        var s = tasks.Result;
        //        Console.WriteLine("I was waiting for async operation to complete..");

        //        Console.WriteLine(s);
        //        client.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message) ;
        //    }

        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.Read();
        //}

    }
}
