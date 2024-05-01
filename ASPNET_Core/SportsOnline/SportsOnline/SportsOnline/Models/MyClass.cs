using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsOnline.Models
{
    public interface IMyClass
    {
       string Title { get; }
    }
    public class MyClass:IMyClass
    {
        public string Title => "hello this is custom class setting title";
    }
}
