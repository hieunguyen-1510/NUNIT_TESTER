using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PowerTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPower_ZeroExponent()
        {
            // Kiểm tra lũy thừa với số mũ bằng 0
            Assert.AreEqual(1.0, Power.CalculatePower(2.0, 0), 0.0001);
            Assert.AreEqual(1.0, Power.CalculatePower(-3.5, 0), 0.0001);
            Assert.AreEqual(1.0, Power.CalculatePower(0, 0), 0.0001);
        }

        [TestMethod]
        public void TestPower_PositiveExponent()
        {
            // Kiểm tra lũy thừa với số mũ dương
            Assert.AreEqual(8.0, Power.CalculatePower(2.0, 3), 0.0001);
            Assert.AreEqual(27.0, Power.CalculatePower(3.0, 3), 0.0001);
            Assert.AreEqual(81.0, Power.CalculatePower(3.0, 4), 0.0001);
        }

        [TestMethod]
        public void TestPower_NegativeExponent()
        {
            // Kiểm tra lũy thừa với số mũ âm
            Assert.AreEqual(0.125, Power.CalculatePower(2.0, -3), 0.0001);
            Assert.AreEqual(1.0 / 27.0, Power.CalculatePower(3.0, -3), 0.0001); // chính xác
            Assert.AreEqual(1.0 / 42.875, Power.CalculatePower(3.5, -3), 0.0001); // chính xác
        }

        [TestMethod]
        public void TestPower_FractionalBase()
        {
            // Kiểm tra lũy thừa với cơ số là số thập phân
            Assert.AreEqual(0.125, Power.CalculatePower(0.5, 3), 0.0001);
            Assert.AreEqual(4.0, Power.CalculatePower(0.5, -2), 0.0001);
        }

        [TestMethod]
        public void TestPower_ZeroBase()
        {
            // Kiểm tra lũy thừa với cơ số bằng 0
            Assert.AreEqual(0.0, Power.CalculatePower(0.0, 3), 0.0001);
            Assert.AreEqual(double.PositiveInfinity, Power.CalculatePower(0.0, -3), 0.0001);
        }
    }
}
