using kata2_fizzbuzz2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.kata2_fizzbuzz2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Generate_Val1_Return1()
        {
            var fizz = FizzBuzz.Generate("1");
            Assert.AreEqual(fizz, 1);
        }
        [TestMethod]
        public void Generate_Val2_Return2()
        {
            var fizz = FizzBuzz.Generate("2");
            Assert.AreEqual(fizz, 2);
        }
        [TestMethod]
        public void Generate_Val3_ReturnFizz()
        {
            var fizz = FizzBuzz.Generate("3");
            Assert.AreEqual(fizz, "Fizz");
        }
        [TestMethod]
        public void Generate_Val4_Return4()
        {
            var fizz = FizzBuzz.Generate("4");
            Assert.AreEqual(fizz, 4);
        }
        [TestMethod]
        public void Generate_Val5_ReturnBuzz()
        {
            var fizz = FizzBuzz.Generate("5");
            Assert.AreEqual(fizz, "Buzz");
        }
        [TestMethod]
        public void Generate_Val6_ReturnFizz()
        {
            var fizz = FizzBuzz.Generate("6");
            Assert.AreEqual(fizz, "Fizz");
        }
        [TestMethod]
        public void Generate_Val15_ReturnFizzBuzz()
        {
            var fizz = FizzBuzz.Generate("15");
            Assert.AreEqual(fizz, "FizzBuzz");
        }
        [TestMethod]
        public void Generate_Val30_ReturnFizzBuzz()
        {
            var fizz = FizzBuzz.Generate("30");
            Assert.AreEqual(fizz, "FizzBuzz");
        }
    }
}
