using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class HinhChuNhatTester
{
    [TestMethod]
    public void TinhDienTich_HinhChuNhatHopLe_TraVeDienTichChinhXac()
    {
        // Sắp xếp
        Diem topLeft = new Diem(1, 4);
        Diem bottomRight = new Diem(4, 1);
        HinhChuNhat hcn = new HinhChuNhat(topLeft, bottomRight);
        int expected = 9;

        // Hành động
        int actual = hcn.TinhDienTich();

        // Kiểm tra
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_InvalidCoordinates_ThrowsArgumentException()
    {
        // Sắp xếp
        Diem topLeft = new Diem(4, 1);
        Diem bottomRight = new Diem(1, 4);

        // Hành động
        HinhChuNhat hcn = new HinhChuNhat(topLeft, bottomRight);

        // Kiểm tra - Được thực hiện bởi ExpectedException
    }

    [TestMethod]
    public void KiemTraGiaoNhau_HinhChuNhatGiaoNhau_TraVeTrue()
    {
        // Sắp xếp
        HinhChuNhat hcn1 = new HinhChuNhat(new Diem(1, 4), new Diem(4, 1));
        HinhChuNhat hcn2 = new HinhChuNhat(new Diem(2, 5), new Diem(5, 2));

        // Hành động
        bool result = hcn1.KiemTraGiaoNhau(hcn2);

        // Kiểm tra
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void KiemTraGiaoNhau_HinhChuNhatKhongGiaoNhau_TraVeFalse()
    {
        // Sắp xếp
        HinhChuNhat hcn1 = new HinhChuNhat(new Diem(1, 4), new Diem(4, 1));
        HinhChuNhat hcn2 = new HinhChuNhat(new Diem(5, 8), new Diem(8, 5));

        // Hành động
        bool result = hcn1.KiemTraGiaoNhau(hcn2);

        // Kiểm tra
        Assert.IsFalse(result);
    }
}
