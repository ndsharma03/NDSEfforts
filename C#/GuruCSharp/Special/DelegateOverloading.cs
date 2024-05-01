using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.Special
{
    public  delegate void GetDataHandler(params object[] param);
    public delegate void DataHandler<T1, T2, T3, T4>(     T1 t1 = default(T1),
                                                          T2 t2 = default(T2),
                                                          T3 t3 = default(T3),
                                                          T4 t4 = default(T4));
    class DelegateOverloading
    {
        // Actaully delegate overloading is not possible but trying to findout a way to make a deleaget to accept overloaded methods.

        public void GetData(string firstName, string lastName, int age) { }
        public void GetData(string firstName) { }
        public void GetData(string firstName,string lastName) { }
        public static void Main1()
        {
            DelegateOverloading obj = new DelegateOverloading();
           // DataHandler<string,Nullable,Nullable,Nullable> _handler+= 
        }

    }


}
