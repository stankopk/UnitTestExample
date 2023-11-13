using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestExample;

namespace UnitTestExampleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfSumEqualSix()
        {
            Example example = new Example();
            int x = example.Sum(new List<int>() { 2,4});
            Assert.AreEqual(6,x,"ТИХО ДЕЕ :(");
        }

        [TestMethod]
        public void TestSumNumberIgnoredIfGreaterThan100()
        {
            Example example = new Example();
            int x = example.Sum(new List<int>() { 2, 102, 4, 204}.Where(s => s < 100).ToList());
            Assert.AreEqual(6, x);
        }
    }
}
