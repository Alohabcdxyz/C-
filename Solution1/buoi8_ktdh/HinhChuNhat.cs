namespace Buoi8_KeThuaVaDaHinh;

public class HinhChuNhat : HinhHoc
{
    public double chieuDai;
    public double chieuRong;

    public void tinhChuVi()
    {
        chuVi = (chieuDai + chieuRong) * 2;
    }

    public void tinhDienTich()
    {
        dienTich = chieuDai * chieuRong;
    }
    
    public void show()
    {
        Console.WriteLine("Dai = " + chieuDai + ", Rong = " + chieuRong + ", Chu vi = " + chuVi + ", Dien tich = " + dienTich);
    }
}