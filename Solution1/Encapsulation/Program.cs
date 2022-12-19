namespace Encapsulation;

class Program
{
    public static HinhChuNhat nhapHCN()
    {
        HinhChuNhat hcn = new HinhChuNhat();
        Console.Write("Chieu dai: ");
        hcn.cd = Double.Parse(Console.ReadLine());
        Console.Write("Chieu rong: ");
        hcn.cr = Double.Parse(Console.ReadLine());
        hcn.tinhC();
        hcn.tinhS();
        return hcn;

    }

    public static HinhTron nhapHT()
    {
        HinhTron ht = new HinhTron();
        Console.Write("Ban Kinh = ");
        ht.r = Double.Parse(Console.ReadLine());
        ht.tinhC();
        ht.tinhS();
        return ht;
    }
    
    public static void Main()
    {
        HinhChuNhat[] arrHCN = new HinhChuNhat[3];
        HinhTron[] arrHT = new HinhTron[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nhap thong tin HCN thu " + (i+1));
            arrHCN[i] = nhapHCN();
        }
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nhap thong tin Hinh Tron thu " + (i+1));
            arrHT[i] = nhapHT();
        }

        double temp = arrHT[0].dienTich;
        for (int i = 0; i < 3; i++)
        {
            for (int j = i + 1; j < 3; j++)
            {
                if (arrHT[i].dienTich > arrHT[j].dienTich)
                {
                    temp = arrHT[i].dienTich;
                    arrHT[i].dienTich = arrHT[j].dienTich;
                    arrHT[j].dienTich = temp;
                }
            }
        }
        
        Console.WriteLine("S HT tang dan: ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Dien tich: " + arrHT[i].dienTich );
        }

        double temp1 = arrHCN[0].chuVi;
        for (int i = 0; i < 3; i++)
        {
            for (int j = i + 1; j < 3; j++)
            {
                if (arrHCN[i].chuVi < arrHCN[j].chuVi)
                {
                    temp1 = arrHCN[i].chuVi;
                    arrHCN[i].chuVi = arrHCN[j].chuVi;
                    arrHCN[j].chuVi = temp1;
                }
            }
        }
        
        Console.WriteLine("C HCN giam dan: ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Chu vi: " + arrHCN[i].chuVi);
        }

    }

}