namespace OOP;

public class HinhTron:HinhHoc
{
    public double r;

    public void tinhC()
    {
        C = (2 * (Math.PI) * r);
    }

    public void tinhS()
    {
        S = ((Math.PI) * (Math.Pow(r,2)));
    }

    public void thongTin()
    {
        Console.Write("r: " + r + ", C: " + C + ", S: " + S);
    }
}