using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{

    public  class MySingleton
    {
        private static MySingleton _objSingleton = null;
        private static object _locker = new object();
        private static int noOfObject = 0;
        private MySingleton()
        {
            noOfObject++;
        }
        public static MySingleton GetInstance
        {
            get
            {
               if (_objSingleton == null)
                {
                   
                        _objSingleton = new MySingleton();
                   
                }
                return _objSingleton;
            }
        }
        public int GetValue(int val)
        {
            Console.WriteLine(_objSingleton.GetHashCode());
            return noOfObject;
        }
    }
    class SingletonTest
    {/*
        static void Main(string[] args)
        {
            //Testing of Singleton 
            //MySingleton obj = new MySingleton(); // error to execute this line as we have declared constructor as private so no one is  able to create instance of this class directly.

            for (int i = 0; i < 1000; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    MySingleton obj = MySingleton.GetInstance;
                    Console.WriteLine("No of singleton Object :" + obj.GetValue(2));
                });
            }

            
            Console.Read();

        }
       */
    }
}
