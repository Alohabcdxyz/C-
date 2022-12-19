namespace Ontap2;

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
        Console.WriteLine("Chu vi: " + hcn.C);
        hcn.tinhS();
        Console.WriteLine("Dien tich: " + hcn.S);
        return hcn;

    }
    
    public static void Main()
    {
        HinhChuNhat[] arrHCN = new HinhChuNhat[3];
        

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nhap thong tin HCN thu " + (i+1));
            arrHCN[i] = nhapHCN();
        }
        
        double maxx = arrHCN[0].S;
        int max = 0;
        for(int i = 0; i<3;i++)
        {
            if (arrHCN[i].S > maxx)
            {
                maxx = arrHCN[i].S;
                max = i;
            }
        }
        Console.Write("Max S: " + maxx + " chieu dai " + arrHCN[max].cd + " chieu rong " + arrHCN[max].cr + " chu vi " + arrHCN[max].C);
    }
}

