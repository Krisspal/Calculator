using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;

namespace CalculatorTester
{
    [TestClass]
    public class BaiTapUnitTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestPower1()
        {
            /*input n = 0, x = 1.0
             output = 1.0*/
            int n = 0;
            double x = 1.0;
            double expected = 1.0;
            Assert.AreEqual(BaiTap.Power(x, n), expected);
        }

        [TestMethod]
        public void TestPower2()
        {
            /*input n = 2, x = 3.0
             output = 9.0*/
            int n = 2;
            double x = 3.0;
            double expected = 9.0;
            Assert.AreEqual(BaiTap.Power(x, n), expected);
        }

        [TestMethod]
        public void TestPower3()
        {
            /*input n = -1, x = 2.0
             output = 0.5*/
            int n = -1;
            double x = 2.0;
            double expected = 0.5;
            Assert.AreEqual(BaiTap.Power(x, n), expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]    
        public void TestPolyn1()
        {
            /*input n = 2, list = {1,2}
             output = throw exception*/
            int n = 2;
            List<int> a = new List<int> { 1, 2};
            Polynomial p = new Polynomial(n, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn2()
        {
            /*input n = 2, list = {1,2,3,4}
             output = throw exception*/
            int n = 2;
            List<int> a = new List<int> { 1, 2, 3, 4};
            Polynomial p = new Polynomial(n, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn3()
        {
            /*input n = -1, list = {1,2,3,4}
             output = throw exception*/
            int n = -1;
            List<int> a = new List<int> { 1, 2, 3, 4 };
            Polynomial p = new Polynomial(n, a);
        }

        [TestMethod]
        public void TestPolyn4()
        {
            /*input n = 2, list = {1,2,3}, x = 1
             output = 6*/
            int n = 2;
            int x = 1;
            List<int> a = new List<int> { 1, 2, 3};
            int expected = 6;
            Polynomial p = new Polynomial(n, a);
            Assert.AreEqual(expected, p.Cal(x));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix1()
        {
            /*input radix = 1, number = 2.
             output = throw exception*/
            int radix = 1;
            int number = 2;
            Radix a = new Radix(number);
            a.ConvertDecimalToAnother(radix);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix2()
        {
            /*input radix = 1, number = 2.
             output = throw exception*/
            int radix = 17;
            int number = 2;
            Radix a = new Radix(number);
            a.ConvertDecimalToAnother(radix);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData3.csv", "TestData3#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestRadix3()
        {
            /*input = TestData3.
             output = Pass*/
            int number = int.Parse(TestContext.DataRow[0].ToString());
            int radix = int.Parse(TestContext.DataRow[1].ToString());
            string expected = TestContext.DataRow[2].ToString();

            Radix a = new Radix(number);
            Assert.AreEqual(a.ConvertDecimalToAnother(radix), expected);
        }
    }
}
