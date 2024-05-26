using System;

public class HinhChuNhat
{
    public Diem TopLeft { get; set; }
    public Diem BottomRight { get; set; }

    public HinhChuNhat(Diem topLeft, Diem bottomRight)
    {
        if (topLeft.X >= bottomRight.X || topLeft.Y <= bottomRight.Y)
        {
            throw new ArgumentException("Invalid coordinates for rectangle.");
        }
        TopLeft = topLeft;
        BottomRight = bottomRight;
    }

    public int TinhDienTich()
    {
        int width = BottomRight.X - TopLeft.X;
        int height = TopLeft.Y - BottomRight.Y;
        return width * height;
    }

    public bool KiemTraGiaoNhau(HinhChuNhat other)
    {
        // Kiểm tra nếu một trong các hình chữ nhật ở bên trái hoặc bên phải hình kia
        if (TopLeft.X >= other.BottomRight.X || other.TopLeft.X >= BottomRight.X)
        {
            return false;
        }

        // Kiểm tra nếu một trong các hình chữ nhật ở phía trên hoặc phía dưới hình kia
        if (BottomRight.Y >= other.TopLeft.Y || other.BottomRight.Y >= TopLeft.Y)
        {
            return false;
        }

        return true;
    }
}
