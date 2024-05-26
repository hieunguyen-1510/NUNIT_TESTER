using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

[TestClass]
public class PolynomialTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_InvalidN_ThrowsArgumentException()
    {
        // Kiểm tra rằng constructor ném ra ArgumentException khi n âm
        int n = -1;
        List<int> coefficients = new List<int> { 1 };
        Polynomial p = new Polynomial(n, coefficients);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_CoefficientsCountMismatch_ThrowsArgumentException()
    {
        // Kiểm tra rằng constructor ném ra ArgumentException khi số lượng hệ số không khớp với n + 1
        int n = 2;
        List<int> coefficients = new List<int> { 1, 2 }; // Không đủ n + 1 phần tử
        Polynomial p = new Polynomial(n, coefficients);
    }

    [TestMethod]
    public void Cal_ValidInput_ReturnsCorrectResult()
    {
        // Kiểm tra phương thức Cal với đa thức hợp lệ và đầu vào hợp lệ, đảm bảo nó trả về kết quả đúng
        int n = 2;
        List<int> coefficients = new List<int> { 1, 2, 3 }; // 1 + 2x + 3x^2
        Polynomial p = new Polynomial(n, coefficients);
        double x = 2;
        int expected = 17; // 1 + 2*2 + 3*2^2

        int actual = p.Cal(x);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Cal_ZeroPolynomial_ReturnsZero()
    {
        // Kiểm tra rằng đa thức với tất cả hệ số bằng 0 trả về kết quả là 0
        int n = 0;
        List<int> coefficients = new List<int> { 0 }; // 0
        Polynomial p = new Polynomial(n, coefficients);
        double x = 5;
        int expected = 0;

        int actual = p.Cal(x);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Cal_ConstantPolynomial_ReturnsConstant()
    {
        int n = 0;
        List<int> coefficients = new List<int> { 7 }; // 7
        Polynomial p = new Polynomial(n, coefficients);
        double x = 5;
        int expected = 7;

        int actual = p.Cal(x);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Cal_NegativeX_ReturnsCorrectResult()
    {
      
        int n = 2;
        List<int> coefficients = new List<int> { 1, -2, 1 }; // 1 - 2x + x^2
        Polynomial p = new Polynomial(n, coefficients);
        double x = -1;
        int expected = 4; // 1 - 2*(-1) + (-1)^2

        int actual = p.Cal(x);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Cal_LargeX_ReturnsCorrectResult()
    {
        // Kiểm tra phương thức Cal với đầu vào lớn, đảm bảo nó trả về kết quả đúng
        int n = 2;
        List<int> coefficients = new List<int> { 1, 0, 1 }; // 1 + x^2
        Polynomial p = new Polynomial(n, coefficients);
        double x = 10;
        int expected = 101; // 1 + 10^2

        int actual = p.Cal(x);
        Assert.AreEqual(expected, actual);
    }
}
