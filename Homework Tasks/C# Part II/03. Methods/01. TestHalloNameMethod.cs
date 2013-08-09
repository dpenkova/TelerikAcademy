using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHalloNameMethod
{
    [TestClass]
    public class TestHalloNameMethod
    {
        [TestMethod]
        public void TestMethodName()
        {
            string name = "Ivan";
            Hello.PrintHelloName(name);
        }

        [TestMethod]
        public void TestMethodEmpty()
        {
            string name = "";
            Hello.PrintHelloName(name);
        }

        [TestMethod]
        public void TestMethodNull()
        {
            string name = null;
            Hello.PrintHelloName(name);
        }

        [TestMethod]
        public void TestMethoSymbols()
        {
            string name = "=+-_)(*&^%$#@!";
            Hello.PrintHelloName(name);
        }
    }
}
