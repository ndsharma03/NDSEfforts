using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.Records
{
    public record class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public record class Employee(string Name,int Age,List<string> Addresses);
}
