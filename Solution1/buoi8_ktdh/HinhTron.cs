namespace Buoi8_KeThuaVaDaHinh;

public class HinhTron : HinhHoc
{
    public const double PI = 3.14;
    public double banKinh;

    public void tinhChuVi()
    {
        chuVi = PI * banKinh;
    }

    public void tinhDienTich()
    {
        dienTich = PI * banKinh * banKinh;
    }

    public void show()
    {
        Console.WriteLine("Ban Kinh = " + banKinh + ", Chu vi: " + chuVi + ", Dien Tich: " + dienTich);
    }
}