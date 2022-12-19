namespace TinhDaHinhKeThua;

public class HinhTRon:HinhHoc
{
    public double bankinh;

    public override double ChuVi()
    {
        return ((Math.PI)*banKinh*2);
    }

    public override double DienTich()
    {
        return ((Math.PI)*banKinh*banKinh);
    }
}