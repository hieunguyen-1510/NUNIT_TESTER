using System;
using System.Collections.Generic;

public class HocVien
{
    public string MaHocVien { get; set; }
    public string TenHocVien { get; set; }
    public string DiaChi { get; set; }
    public double DiemToan { get; set; }
    public double DiemVan { get; set; }
    public double DiemAnh { get; set; }

    public HocVien(string maHocVien, string tenHocVien, string diaChi, double diemToan, double diemVan, double diemAnh)
    {
        MaHocVien = maHocVien;
        TenHocVien = tenHocVien;
        DiaChi = diaChi;
        DiemToan = diemToan;
        DiemVan = diemVan;
        DiemAnh = diemAnh;
    }

    public double DiemTrungBinh()
    {
        return (DiemToan + DiemVan + DiemAnh) / 3;
    }

    public bool CoTheNhanHocBong()
    {
        return DiemTrungBinh() >= 8.0;
    }
}


public static class Program
{
    public static List<HocVien> TimHocVienNhanHocBong(List<HocVien> danhSach)
    {
        var result = new List<HocVien>();
        foreach (var hv in danhSach)
        {
            if (hv.CoTheNhanHocBong())
            {
                result.Add(hv);
            }
        }
        return result;
    }
}