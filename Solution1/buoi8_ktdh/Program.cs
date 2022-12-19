namespace Buoi8_KeThuaVaDaHinh;

class Program
{

    public static HinhChuNhat nhapHCN()
    {
        HinhChuNhat item = new HinhChuNhat();
        Console.Write("Chieu dai = ");
        item.chieuDai = Double.Parse(Console.ReadLine());
        Console.Write("Chieu rong = ");
        item.chieuRong = Double.Parse(Console.ReadLine());
        item.tinhChuVi();
        item.tinhDienTich();
        return item;
    }

    public static HinhTron nhapHT()
    {
        HinhTron item = new HinhTron();
        Console.Write("Ban Kinh = ");
        item.banKinh = Double.Parse(Console.ReadLine());
        item.tinhChuVi();
        item.tinhDienTich();
        return item;
    }
    
    public static void Main()
    {
        int hcnSize = 3;
        int htSize = 3;

        HinhChuNhat[] arrHCN = new HinhChuNhat[hcnSize];
        HinhTron[] arrHT = new HinhTron[htSize];

        for (int i = 0; i < hcnSize; i++)
        {
            Console.WriteLine("Nhap thong so HCN thu " + (i+1));
            arrHCN[i] = nhapHCN();
        }
        
        for (int i = 0; i < htSize; i++)
        {
            Console.WriteLine("Nhap thong so Hinh Tron thu " + (i+1));
            arrHT[i] = nhapHT();
        }
        
        for (int i = 0; i < hcnSize - 1; i++)
        {
            for (int j = 0; j < hcnSize - i - 1; j++)
            {
                if (arrHCN[j].dienTich > arrHCN[j + 1].dienTich)
                {
                    HinhChuNhat temp = arrHCN[j];
                    arrHCN[j] = arrHCN[j + 1];
                    arrHCN[j + 1] = temp;
                }
            }
        }

        foreach (var item in arrHCN)
        {
            item.show();
        }
    }
}

