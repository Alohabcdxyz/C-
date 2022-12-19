namespace OOP;

public class HinhChuNhat:HinhHoc
{
    public double cd, cr;

    public void tinhC()
    {
        C = (cd + cr) * 2;
    }

    public void tinhS()
    {
        S = cd * cr;
    }
    
}