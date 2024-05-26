using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RadixTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadixConstructor_NegativeNumber_ThrowsArgumentException()
        {
            // Kiểm tra khởi tạo Radix với số âm
            var radix = new Radix(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvertDecimalToAnother_InvalidRadix_ThrowsArgumentException()
        {
            // Kiểm tra chuyển đổi với cơ số không hợp lệ (dưới 2)
            var radix = new Radix(10);
            radix.ConvertDecimalToAnother(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvertDecimalToAnother_InvalidRadixHigh_ThrowsArgumentException()
        {
            // Kiểm tra chuyển đổi với cơ số không hợp lệ (trên 16)
            var radix = new Radix(10);
            radix.ConvertDecimalToAnother(17);
        }

        [TestMethod]
        public void TestConvertDecimalToAnother_ValidBinaryConversion()
        {
            // Kiểm tra chuyển đổi hợp lệ sang nhị phân
            var radix = new Radix(10);
            var result = radix.ConvertDecimalToAnother(2);
            Assert.AreEqual("1,0,1,0", result);
        }

        [TestMethod]
        public void TestConvertDecimalToAnother_ValidHexConversion()
        {
            // Kiểm tra chuyển đổi hợp lệ sang thập lục phân
            var radix = new Radix(255);
            var result = radix.ConvertDecimalToAnother(16);
            Assert.AreEqual("F,F", result);
        }

        [TestMethod]
        public void TestConvertDecimalToAnother_ValidOctalConversion()
        {
            // Kiểm tra chuyển đổi hợp lệ sang bát phân
            var radix = new Radix(64);
            var result = radix.ConvertDecimalToAnother(8);
            Assert.AreEqual("1,0,0", result);
        }

        [TestMethod]
        public void TestConvertDecimalToAnother_ZeroInput()
        {
            // Kiểm tra chuyển đổi với số 0
            var radix = new Radix(0);
            var result = radix.ConvertDecimalToAnother(2);
            Assert.AreEqual("", result);  // Số 0 sẽ trả về chuỗi rỗng
        }
    }
}
