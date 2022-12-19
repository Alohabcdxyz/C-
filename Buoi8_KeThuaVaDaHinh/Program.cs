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
        Console.WriteLine("Chu vi = " + item.chuVi);
        item.tinhDienTich();
        Console.WriteLine("Dien tich = " + item.dienTich);
        return item;
    }
    
    public static void Main()
    {
        int hcnSize = 3;
        int htSize = 3;

        HinhChuNhat[] arrHCN = new HinhChuNhat[hcnSize];
        
        for (int i = 0; i < hcnSize; i++)
        {
            Console.WriteLine("Nhap thong so HCN thu " + (i+1));
            arrHCN[i] = nhapHCN();
        }

        // for (int i = 0; i < hcnSize - 1; i++)
        // {
        //     for (int j = 0; j < hcnSize - i - 1; j++)
        //     {
        //         if (arrHCN[j].dienTich > arrHCN[j + 1].dienTich)
        //         {
        //             HinhChuNhat temp = arrHCN[j];
        //             arrHCN[j] = arrHCN[j + 1];
        //             arrHCN[j + 1] = temp;
        //         }
        //     }
        // }
          
        double maxx = arrHCN[0].dienTich;
        for(int i = 0; i<3;i++)
        {
            if (arrHCN[i].dienTich > maxx)
            {
                maxx = arrHCN[i].dienTich;
            }
        }
        
        foreach (var item in arrHCN)
        {
            item.show();
        }
    }
}

