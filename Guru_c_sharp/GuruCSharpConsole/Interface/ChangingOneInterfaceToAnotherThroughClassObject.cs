using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GuruCSharpConsole.Interface
{
   /// <summary>
    ///  Class object who implements interface, is convertible to any Interface(which class implements).
   /// </summary>

    public interface IPlugin
    {
        void PluginMethod();
    }
    public interface IEntityList
    {
        void RefrestListView();
    }

    public class Form1:IPlugin,IEntityList
    {
            public void PluginMethod()
            {
                Console.WriteLine("PluginMethod!!!");
            }

            public void RefrestListView()
            {
                Console.WriteLine("RefrestListView!!!");
            }
    }

    public class ObjectConverter
    {
        // this method will convert IPlugin object to IEntityObject.
        public static IEntityList ConvertToIEntityList(IPlugin obj)
        {
            IEntityList entityList = (Form1)obj;
            return entityList;
        }

        // this method will convert IEntityObject  object to IPlugin.
        public static IPlugin ConvertToIPlugin(IEntityList obj)
        {
            IPlugin plugin = (Form1)obj;
            return plugin;
        }
    }
    //public class Tester
    //{
        //******************* Open commented section below to run this example *****************
        
        //public static void Main()
        //{

        //    //We have form object and we will get IEntityList and IPlugin object through it and will call respective methods.
        //    Form1 formObject = new Form1();

        //    //passing form object to method to get IEntityList.
        //    IEntityList entityList = ObjectConverter.ConvertToIEntityList(formObject);

        //    //passing form object to method to get IPlugin.
        //    IPlugin plugin = ObjectConverter.ConvertToIPlugin(formObject);

        //    //Calling respective methods from converted object.
        //    entityList.RefrestListView();
        //    plugin.PluginMethod();
            
        //}
      
    //}
}
