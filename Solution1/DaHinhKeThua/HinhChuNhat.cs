namespace TinhDaHinhKeThua;

public class HinhChuNhat : HinhHoc
{
    public double chieuDai;
    public double chieuRong;

    public override double ChuVi()
    {
        return ((chieuDai + chieuRong) * 2);
    }

    public void  DienTich()
    {
        s = chieuDai * chieuRong;
    }
    
    public void ThongTin()
    {
        Console.WriteLine("Dai = " + chieuDai + ", Rong = " + chieuRong + ", Chu vi = " + chuVi + ", Dien tich = " + dienTich);
    }
}