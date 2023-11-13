using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample;

namespace UnitTestExampleTest
{
    [TestClass]
    public class DivierTest
    {
        [TestMethod]
        public void TestDivide12by3()
        {
            Divider d = new Divider();
            var res = d.Divide(12, 3);

            Assert.AreEqual(4, res, "The method Divide returned wrong result when 12 was divided by 3");
        }
    }
}
