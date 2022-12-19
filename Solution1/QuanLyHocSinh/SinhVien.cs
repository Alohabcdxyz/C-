namespace QuanLyHocSinh;

public class SinhVien
{
    public string ID{ get; set; }
    public string Name{ get; set; }
    public string sdt{ get; set; }
    public string diaChi{ get; set; }
    public string mail{ get; set; }

    public SinhVien()
    {
        
    }

    public SinhVien(string ID, string Name, string sdt, string diaChi, string mail)
    {
        this.ID = ID;
        this.mail = mail;
        this.Name = Name;
        this.sdt = sdt;
        this.diaChi = diaChi;
    }

    public void nhapThongTin()
    {
        Console.WriteLine("Nhap ma sinh vien: ");
        ID = Console.ReadLine();
        Console.WriteLine("Nhap ten sinh vien: ");
        Name = Console.ReadLine();
        Console.WriteLine("Nhap SDT: ");
        sdt = Console.ReadLine();
        Console.WriteLine("Nhap dia chi: ");
        diaChi = Console.ReadLine();
        Console.WriteLine("Nhap email: ");
        mail = Console.ReadLine();
    }
    
}