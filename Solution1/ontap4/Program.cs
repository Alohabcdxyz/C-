namespace ontap4;

class Program
{
    public static hocSinh nhapThongTin()
    {
        hocSinh hs = new hocSinh();
        Console.Write("Ma SV: ");
        hs.maSinhVien = int.Parse(Console.ReadLine());
        Console.Write("Ten: ");
        hs.hoTen = Console.ReadLine();
        Console.Write("Diem Van:");
        hs.diemvan = Double.Parse(Console.ReadLine());
        Console.Write("Diem Toan:");
        hs.diemToan = Double.Parse(Console.ReadLine());
        Console.Write("Diem TA:");
        hs.diemTA = Double.Parse(Console.ReadLine());
        hs.diemTB = (hs.diemvan + hs.diemToan + hs.diemTA) / 3;
        return hs;

    }
    
    public static void Main()
    {
        hocSinh[] arrSV = new hocSinh[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nhap thong tin hoc sinh thu " + (i+1));
            arrSV[i] = nhapThongTin();
        }  
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Diem trung binh hoc sinh : " + arrSV[i].hoTen);
            Console.WriteLine(arrSV[i].diemTB);
        }

        double maxx = arrSV[0].diemTB;
        int id1 = 0;
        int id2 = 0;
        for(int i = 1; i < 3; i++)
        {
            if (arrSV[i].diemTB > maxx)
            {
                maxx = arrSV[i].diemTB;
                id1 = i;
            }
        }
        Console.WriteLine("Diem TB lon nhat la " + maxx + " ho ten: " + arrSV[id1].hoTen + " diem van: " + arrSV[id1].diemvan + " diem anh " + arrSV[id1].diemTA + " diem toan: " + arrSV[id1].diemToan);
        
        double min = arrSV[0].diemTB;
 
        for(int i = 1; i < 3; i++)
        {
            if (arrSV[i].diemTB < min)
            {
                min = arrSV[i].diemTB;
                id2 = i;
            }
        }
        Console.WriteLine("Diem TB nho nhat la " + min + " ho ten: " + arrSV[id2].hoTen + " diem van: " + arrSV[id2].diemvan + " diem anh " + arrSV[id2].diemTA + " diem toan: " + arrSV[id2].diemToan);
    }

}

