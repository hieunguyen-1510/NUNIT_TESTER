using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HocVienTester
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestDiemTrungBinh()
        {
            var hv = new HocVien("001", "Nguyen Van A", "Ha Noi", 9, 8, 7);
            Assert.AreEqual(8.0, hv.DiemTrungBinh(), 0.01);
        }

        [TestMethod]
        public void TestCoTheNhanHocBong()
        {
            var hv1 = new HocVien("001", "Nguyen Van A", "Ha Noi", 9, 8, 7);
            Assert.IsTrue(hv1.CoTheNhanHocBong());

            var hv2 = new HocVien("002", "Tran Thi B", "Hai Phong", 9, 4, 7);
            Assert.IsFalse(hv2.CoTheNhanHocBong());
        }

        [TestMethod]
        public void TestTimHocVienNhanHocBong()
        {
            var hv1 = new HocVien("001", "Nguyen Van A", "Ha Noi", 9, 8, 7);
            var hv2 = new HocVien("002", "Tran Thi B", "Hai Phong", 9, 4, 7);
            var hv3 = new HocVien("003", "Le Van C", "Da Nang", 8, 8, 8);

            var danhSach = new List<HocVien> { hv1, hv2, hv3 };
            var ketQua = Program.TimHocVienNhanHocBong(danhSach);

            Assert.AreEqual(2, ketQua.Count);
            CollectionAssert.Contains(ketQua, hv1);
            CollectionAssert.Contains(ketQua, hv3);
            CollectionAssert.DoesNotContain(ketQua, hv2);
        }
    }
}
