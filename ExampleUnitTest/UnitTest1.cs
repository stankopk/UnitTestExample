using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestExample;

namespace ExampleUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            Example e = new Example();
            var sum = e.Sum(2, 4);
            Assert.AreEqual(6, sum);
        }
    }
}
