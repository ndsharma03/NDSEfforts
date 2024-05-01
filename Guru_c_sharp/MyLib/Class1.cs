using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class CLASS2
    {
        private string _name = "niranjan";

        protected void M1()
        {
            Console.WriteLine("Hello");
        }
        protected string Name
        {
            private get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }

    public class CLASS3 : CLASS2
    {
    }
}
