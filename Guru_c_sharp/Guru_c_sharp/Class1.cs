using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru_c_sharp
{
    class Class1
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
}
