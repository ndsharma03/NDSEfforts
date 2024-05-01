using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFilters2020.Polymorphism
{
    public interface IMyService
    {
        string AppendHello(string name);
    }

    public class MyService1 : IMyService
    {
        public string AppendHello(string name)
        {
            return "Hello " + name;
        }
    }
    public class MyService2 : IMyService
    {
        public string AppendHello(string name)
        {
            return "Hello " + name + "Ji";
        }
    }
}
