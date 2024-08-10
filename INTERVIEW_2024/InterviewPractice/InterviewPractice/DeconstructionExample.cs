using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class DeconstructionExample
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string Name,out int Age)
        {
            Name = this.Name;
            Age = this.Age;
        }
    }

}
