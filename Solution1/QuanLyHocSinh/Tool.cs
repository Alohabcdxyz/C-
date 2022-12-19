using System.Collections;

namespace QuanLyHocSinh;

public class Tool
{
    private List<SinhVien> ListSinhVien = null;
    public Tool() {
        ListSinhVien = new List<SinhVien>();
    }

    public void insert()
    {
        SinhVien sv = new SinhVien();
        sv.nhapThongTin();
        ListSinhVien.Add(sv);
    }
    
    public SinhVien FindByID(String ID)
    {
        SinhVien searchResult = null;
        if (ListSinhVien != null && ListSinhVien.Count > 0)
        {
            foreach (SinhVien sv in ListSinhVien)
            {
                if (sv.ID == ID)
                {
                    searchResult = sv;
                }
            }
        }
        return searchResult;
    }

    public void update(String ID)
    {
        SinhVien sv = FindByID(ID);
     
        if (sv != null)
        {
            Console.Write("Nhap ma sinh vien: ");
            string id = Convert.ToString(Console.ReadLine());
            if (id != null && id.Length > 0)
            {
                sv.ID = id;
            }
            
            Console.Write("Nhap ten sinh vien: ");
            string name = Convert.ToString(Console.ReadLine());
          
            if (name != null && name.Length > 0)
            {
                sv.Name = name;
            }
            
            Console.Write("Nhap sdt sinh vien: ");
            string sdt = Convert.ToString(Console.ReadLine());
            if (sdt != null && sdt.Length > 0)
            {
                sv.sdt = sdt;
            }

            Console.Write("Nhap dia chi sinh vien: ");
            string diachi = Convert.ToString(Console.ReadLine());
            if (diachi != null && diachi.Length > 0)
            {
                sv.diaChi = diachi;
            }
            
            Console.Write("Nhap mail sinh vien: ");
            string mail = Convert.ToString(Console.ReadLine());
            if (mail != null && mail.Length > 0)
            {
                sv.mail = mail;
            }
        }
        else
        {
            Console.WriteLine("Sinh vien co ID = {0} khong ton tai.", ID);
        }
    }
    
    public bool DeleteById(String ID)
    {
        bool xoaSV = false;
        SinhVien sv = FindByID(ID);
        if (sv != null)
        {
            xoaSV = ListSinhVien.Remove(sv);
        }
        return xoaSV;
    }

    public int SoLuongSinhVien()
    {
        int Count = 0;
        if (ListSinhVien != null)
        {
            Count = ListSinhVien.Count;
        }
        return Count;
    }
    
    public void ShowSinhVien(List<SinhVien> listSV)
    {
        if (listSV != null && listSV.Count > 0)
        {
            foreach (SinhVien sv in listSV)
            {
                Console.WriteLine("ID: " + sv.ID 
                                         + ", Name: "  + sv.Name 
                                         + ", sdt: " + sv.sdt 
                                         + ", mail: " + sv.mail 
                                         + ", dia chi: " +  sv.diaChi);
            }
        }
        Console.WriteLine();
    }
    
    public List<SinhVien> getListSinhVien()
    {
        return ListSinhVien;
    }
}