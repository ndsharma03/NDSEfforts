using NUnit.Framework;
using FizzBuzzLib;
namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void Test1(int input )
        {
            string returnValue = FizzBuzz.Get(input);
            Assert.AreEqual("Fizz", returnValue);

        }
        [TestCase(5)]
        [TestCase(10)]
        public void Test2(int input)
        {
            string returnValue = FizzBuzz.Get(input);
            Assert.AreEqual("Buzz", returnValue);
            
        }
        [TestCase(15)]
        public void Test3(int input)
        {
            string returnValue = FizzBuzz.Get(input);
            Assert.AreEqual("FizzBuzz", returnValue);
           
        }
    }
}