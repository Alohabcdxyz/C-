namespace Encapsulation;

public class HinhTron:HinhHoc2D
{
    public double r;

    public void tinhC()
    {
        chuVi = (2 * (Math.PI) * r);
    }

    public void tinhS()
    {
        dienTich = ((Math.PI) * (Math.Pow(r,2)));
    }

    public void show()
    {
        Console.WriteLine("R: " + r + ", C: " + chuVi + ", S: " + dienTich);
    }
}