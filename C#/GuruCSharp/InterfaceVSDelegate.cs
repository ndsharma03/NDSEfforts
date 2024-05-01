using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp
{

    interface ITest
    {
        void InterfaceMethod(string name);
    }
    public delegate void DelegateMethod(string name);
    class InterfaceVSDelegate
    {
       public static DelegateMethod _delegate;
       public static void M1(string name)
        {
            if (_delegate != null)
            {
                _delegate(name);
            }
            //Console.WriteLine("Hello" + name);
        }

        public void M2(DelegateMethod callback)
        {
            if (callback != null)
                callback("Hello");
        }
    }

    class DelegateTester
    {
        //public static void Main()
        //{
        //    InterfaceVSDelegate._delegate += new DelegateTester().Printer;
        //    InterfaceVSDelegate.M1("Shri Ganesh");

        //    InterfaceVSDelegate obj = new InterfaceVSDelegate();
        //    obj.M2(new DelegateTester().Printer);
          
        //    Console.Read();
        //}
        private  void Printer(string s)
        {
            Console.WriteLine("Hello" + s);
        }
    }
    class Tester
    {
        //public static void Main()
        //{
        //    Tester t = new Tester();
        //    t.method1();
        //}
       private void method1()
        {
            Console.WriteLine(  "Mehtod1");
        }
    }

    public class Tester2
    {
        //public static void Main()
        //{
        //    IEnumerable<int> list = Enumerable.Range(0, 200);
        //    Stopwatch st = new Stopwatch();
        //    st.Start();
        //    pertformaceTesterforLoop(list);
        //    st.Stop();
        //    string s = st.ElapsedTicks.ToString();
        //    Console.WriteLine(st.ElapsedTicks);
        //    st.Reset();
        //    st.Restart();
        //    pertformaceTesterforDelegate(list);
        //    st.Stop();
        //     s += "--------" +st.ElapsedTicks.ToString();
        //    Console.WriteLine(s);
        //    Console.Read();
        //}

        public static void pertformaceTesterforLoop(IEnumerable<int> list)
        {
            for(int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine("for loop" + i);
            }
        }
        public static void pertformaceTesterforDelegate(IEnumerable<int> list)
        {
            Parallel.ForEach(list, x => Console.WriteLine("Delegate" + x));
        }
    }
}

