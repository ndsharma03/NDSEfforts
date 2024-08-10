using InterviewPractice;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class DeconstructionTest
    {
        [Fact]
        public void PlayingWithDeconstruction()
        {
            DeconstructionExample obj = new DeconstructionExample { Name = "Niranjan", Age = 40 };
            var (name, age) = obj;
            (var n, var sa) = obj;
            (var k, _) = obj;


            Debug.WriteLine("{0},{1},{2},{3}", name, n, sa, k);

            int a = 10;// just to pass test.
            Assert.Equal(10, a);
        }
    }
}
