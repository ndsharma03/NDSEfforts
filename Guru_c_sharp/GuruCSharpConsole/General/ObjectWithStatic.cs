using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{
    public class AppMgr
    {
       public static PluinMgr PluginManager { get; set; }
       static AppMgr()
       {
           PluginManager = new PluinMgr();
       }
    }
    public class PluinMgr
    {
        public static  void REgisterEventHandlers(string s)
        {
            Console.WriteLine(" PluginManager called " + s);
        }
    }

    class ObjectWithStatic
    {
        //public static void Main()
        //{
        //    AppMgr.PluginManager.REgisterEventHandlers("App manager contians a static property of PluinMgr class,we are able to calldirectly registerEventHandler ()");
        //    Console.ReadLine();
        //}
    }
}
