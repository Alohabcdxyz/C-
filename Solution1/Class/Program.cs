// See https://aka.ms/new-console-template for more information

// using classOOP;

class HinhCHuNhat
{
    public double cd;
    public double cr;
    
    
    public void Nhap()
    {
        Console.WriteLine("Nhap chieu dai: ");
        cd = Double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu rong: ");
        cr = Double.Parse(Console.ReadLine());
    }
    
    public void TinhCHuVi()
    {
        double chuVi = (cd + cr) * 2;
        Console.WriteLine("Chu vi hinh chu nhat la " + chuVi);
    }
    public void TinhDienTich()
    {
        double dienTich = (cd * cr);
        Console.WriteLine("Dien tich hinh chu nhat la " + dienTich);
    }
    
}