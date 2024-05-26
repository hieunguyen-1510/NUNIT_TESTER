using _16_NguyenLeHoaiHieu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;

        [TestInitialize]
        public void SetUp()
        {
            c = new Calculation(10, 5);
        }

        [TestMethod]
        public void Test_Cong()
        {
            int expected = 15;
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Tru()
        {
            int expected = 5;
            int actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhan()
        {
            int expected = 50;
            int actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Chia()
        {
            int expected = 2;
            int actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c = new Calculation(10, 0);
            c.Execute("/");
        }

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "C:\\Users\\ASUS\\source\\repos\\16_NguyenLeHoaiHieu\\CalculatorTester\\TestDataToantu.csv",
                    "TestDataToantu#csv",
                    DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestCongDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow["operation"].ToString().Trim();
            int expected = int.Parse(TestContext.DataRow["expected"].ToString());

            Calculation c = new Calculation(a, b);
            int actual = c.Execute(operation);
            //Assert.AreEqual(expected, actual);
        }
    }
}
