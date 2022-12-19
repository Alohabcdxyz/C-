using QuanLyHocSinh;

namespace BaiTapQLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Tool quanLySinhVien = new Tool();
 
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Hien thi sinh vien");
                Console.WriteLine("2. Them SV");
                Console.WriteLine("3. Sua thong tin");
                Console.WriteLine("4. Xoa SV");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("Nhap lua chon: ");
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("1. Hien thi danh sach sinh vien.");
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("2. Them sinh vien.");
                        quanLySinhVien.insert();
                        Console.WriteLine("Them sinh vien thanh cong!");
                        break;
                    case 3:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            String ID;
                            Console.WriteLine("3. Cap nhat thong tin sinh vien. ");
                            Console.Write("Nhap ID: ");
                            ID = Console.ReadLine();
                            quanLySinhVien.update(ID);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 4:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            String ID;
                            Console.WriteLine("4. Xoa sinh vien.");
                            Console.Write("Nhap ID: ");
                            ID = Console.ReadLine();
                            if (quanLySinhVien.DeleteById(ID))
                            {
                                Console.WriteLine("Sinh vien co id = {0} da bi xoa.", ID);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        return;
                }
            }
        }
    }
}