namespace Buoi8_KeThuaVaDaHinh;

public class HinhChuNhat 
{
    public double chieuDai, chieuRong, chuVi, dienTich;

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