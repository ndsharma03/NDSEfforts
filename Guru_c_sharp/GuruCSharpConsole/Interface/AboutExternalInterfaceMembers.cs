using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.Interface
{
    // *************Points to remember******************
 
    // A class can implement interface either externaly/internaly. 
    // only immediate derived class of interface can implement interface externaly .
    // we can not apply any access modifier on external implemented interface methods.
    //external implemented interface members can call only via interface reference.
    // you can not declare delaegate inside interface however you can declare it outside and in interface create a property of delegate type.
    //**************************************************
    
    
    public delegate void MyDel();


    interface IB
    {
        string Name{get;}
    }
    interface IA
    {
        void m1();
        MyDel del { get; set; }
        event MyDel MyDelEvent;
    }
    class ClassInterfaceImplementor:IA
    {
        
       void IA.m1(){
           Console.WriteLine("ClassInterfaceImplementor");
           if (del != null)
           {
               del();
           }
        }
       public MyDel del
       {
           get;
           set;
       }
     public event MyDel MyDelEvent;
    }
    class ClassDerived : ClassInterfaceImplementor,IB
    {
        //this class can Not implement interface externally


        #region IB implementation
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
#endregion
    }

    class Program
    {
        //public static void Main()
        //{
        //    ClassDerived d = new ClassDerived();
        //    d.del = new MyDel(() => { Console.WriteLine("hello"); });
        //    ((IA)d).m1();


        //    d.Name = "niranjan";
        //    Console.WriteLine(d.Name);

        //    Console.Read();
        //}
    }
}
