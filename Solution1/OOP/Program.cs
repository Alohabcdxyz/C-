namespace OOP;

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

        double temp = arrHCN[0].S;
        for (int i = 0; i < 3; i++)
        {
            for (int j = i + 1; j < 3; j++)
            {
                if (arrHCN[i].S > arrHCN[j].S)
                {
                    temp = arrHCN[j].S;
                    arrHCN[j].S = arrHCN[i].S;
                    arrHCN[i].S = temp;
                }
            }
        }
        
        Console.WriteLine("S HCN tang dan: ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("chieu dai: " + arrHCN[i].cd + ", chieu rong: " + arrHCN[i].cr + ", chu vi: " + arrHCN[i].C + ", dien tich: " + arrHCN[i].S + "; ");
        }
    }

}