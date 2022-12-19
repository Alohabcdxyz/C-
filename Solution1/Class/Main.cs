namespace Class;

public class Main1
{
    public static void Main()
    {
        HinhCHuNhat HCN = new HinhCHuNhat();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nhap HCN so " + (i + 1));
            HCN.Nhap();
            HCN.TinhCHuVi();
            HCN.TinhDienTich();
        }

    }
}