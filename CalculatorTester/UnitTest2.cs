using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestVoSoNghiem()
        {
            SimpleEquation a = new SimpleEquation(0, 0);
            Assert.AreEqual(a.SingleEquation(), "VSN");
        }

        [TestMethod]
        public void TestVoNghiem()
        {
            SimpleEquation a = new SimpleEquation(0, 2);
            Assert.AreEqual(a.SingleEquation(), "VN");
        }

        [TestMethod]
        public void TestCoNghiem()
        {
            SimpleEquation a = new SimpleEquation(1, 2);
            Assert.AreEqual(a.SingleEquation(), "-2");
        }

    }
}
