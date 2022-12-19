namespace Encapsulation;

public class HinhChuNhat:HinhHoc2D
{
    public double cd, cr;
    
    public void tinhC()
    {
        chuVi = (cd + cr) * 2;
    }

    public void tinhS()
    {
        dienTich = cd * cr;
    }

}