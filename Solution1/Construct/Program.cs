

public class Program
{
    public struct sinhVien
    {
        public string maSinhVien;
        public string hoTen;
        public int tuoi;
        public double diemProgramming;
        public double diemDB;
        public double diemWeb;
        public double diemPrj1;
        public double diemSDLC;
        public double diemMaths;
        public double diemAP;
        public double Professional;
        public double diemTB;
    }

    public static void Main()
    {
        sinhVien[] arrSinhVien = new sinhVien[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Nhap sinh vien so" + (i+1));
            Console.Write("Ma Sinh Vien:");
            arrSinhVien[i].maSinhVien = Console.ReadLine();
            Console.Write("Ho Ten:");
            arrSinhVien[i].hoTen = Console.ReadLine();
            Console.Write("Tuoi:");
            arrSinhVien[i].tuoi = int.Parse(Console.ReadLine());
            Console.Write("Programming:");
            arrSinhVien[i].diemProgramming = Double.Parse(Console.ReadLine());
            Console.Write("DB:");
            arrSinhVien[i].diemDB = Double.Parse(Console.ReadLine());
            Console.Write("Diem WEB:");
            arrSinhVien[i].diemWeb = Double.Parse(Console.ReadLine());
            Console.Write("Diem PRJ1:");
            arrSinhVien[i].diemPrj1 = Double.Parse(Console.ReadLine());
            Console.Write("Diem SDLC:");
            arrSinhVien[i].diemSDLC = Double.Parse(Console.ReadLine());
            Console.Write("Diem MATHS:");
            arrSinhVien[i].diemMaths = Double.Parse(Console.ReadLine());
            Console.Write("Diem AP:");
            arrSinhVien[i].diemAP = Double.Parse(Console.ReadLine());
            Console.Write("Diem Professional:");
            arrSinhVien[i].Professional = Double.Parse(Console.ReadLine());
            
            arrSinhVien[i].diemTB = (arrSinhVien[i].diemProgramming + arrSinhVien[i].diemDB + arrSinhVien[i].diemWeb +
                                    arrSinhVien[i].diemPrj1 + arrSinhVien[i].diemSDLC + arrSinhVien[i].diemMaths +
                                    arrSinhVien[i].diemAP + arrSinhVien[i].Professional)/8;

        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Danh sach diem trung binh:");
            Console.WriteLine(arrSinhVien[i].diemTB);
        }

        double temp = arrSinhVien[0].diemTB;
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (arrSinhVien[i].diemTB > arrSinhVien[j].diemTB)
                {
                    temp = arrSinhVien[j].diemTB;
                    arrSinhVien[j].diemTB = arrSinhVien[i].diemTB;
                    arrSinhVien[i].diemTB = temp;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Tang dan:");
            Console.WriteLine(arrSinhVien[i].diemTB);
        }
        
    }
}