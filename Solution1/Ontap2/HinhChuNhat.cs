namespace Ontap2;

public class HinhChuNhat
{
    public double cd, cr, C, S;

    public void tinhC()
    {
        C = (cd + cr) * 2;
    }

    public void tinhS()
    {
        S = cd * cr;
    }
    
}