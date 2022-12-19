namespace BaiKiemTra2;

public class hocSInh
{
    public int maSinhVien;
    public string hoTen;
    public float diemToan;
    public float diemVan;
    public float diemAnh;
    public float diemTrungBinh;

    public void tinhDiemTrungBinh()
    {
        diemTrungBinh = (diemToan + diemAnh + diemVan) / 3;
        
    }
    
    public void show()
    {
        Console.WriteLine("Ma hoc sinh: " + maSinhVien + ", ho ten: " + hoTen + ", diem toan: " + diemToan + ", diem van: " + diemVan + ", diem anh: " + diemAnh + ", diem trung binh: " + diemTrungBinh );
    }
}