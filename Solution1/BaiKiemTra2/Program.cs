namespace BaiKiemTra2;

class Program
{
    public static hocSInh nhapThongTin()
    {
        hocSInh hs = new hocSInh();
        Console.Write("Nhap ma hoc sinh: ");
        hs.maSinhVien = int.Parse(Console.ReadLine());
        Console.Write("Nhap ho va ten: ");
        hs.hoTen = Console.ReadLine();
        Console.Write("Nhap diem toan: ");
        hs.diemToan = float.Parse(Console.ReadLine());
        Console.Write("Nhap diem van: ");
        hs.diemVan = float.Parse(Console.ReadLine());
        Console.Write("Nhap diem anh: ");
        hs.diemAnh = float.Parse(Console.ReadLine());
        hs.tinhDiemTrungBinh();
        Console.WriteLine("Diem trung binh: " + hs.diemTrungBinh);
        return hs;
    }

    public static void Main()
    {
        hocSInh[] arrHS = new hocSInh[10];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Nhap thong tin hoc sinh thu " + (i + 1));
            arrHS[i] = nhapThongTin();
        }
        
        float temp = arrHS[0].diemTrungBinh;
        for (int i = 0; i < 4; i++)
        {
            for (int j = i + 1; j < 4; j++)
            {
                if (arrHS[i].diemTrungBinh < arrHS[j].diemTrungBinh)
                {
                    temp = arrHS[j].diemTrungBinh;
                    arrHS[j].diemTrungBinh = arrHS[i].diemTrungBinh;
                    arrHS[i].diemTrungBinh = temp;
                }
            }
        }
        
        Console.Write("Diem trung binh giam dan:");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(arrHS[i].diemTrungBinh + "; ");
        }

    }  
}

