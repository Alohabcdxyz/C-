//See https://aka.ms/new-console-template for more information
//
// class MyClass
// {
//     public static int nhapN()
//     {
//         int n;
//         Console.Write("n = ");
//         n = int.Parse(Console.ReadLine());
//         return n;
//     }
//     public static int tinhGiaiThua(int n)
//     {
//         int gt = 1;
//         for (int i = 1; i <= n; i++)
//         {
//             gt *= i;
//         }
//
//         return gt;
//     }
//
//     public static void show(int n)
//     {
//         Console.WriteLine("gt = " + tinhGiaiThua(n));
//     }
//     public static void Main()
//     {
//         int n = nhapN();
//         show(n);
//     }
// }

class MyClass
{
    public static int nhapN()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        return n;
    }
    public static int tinhTong(int n)
    {
        int tong = 0;
        for (int i = 0; i <= n; i++)
        {
            if(i %2 == 0)
            tong += i;
        }

        return tong;
    }

    public static void checkSNT(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            Console.WriteLine("Day la SNT");
        }
        else
        {
            Console.WriteLine("Day khong phai So Nguyen To !");
        }
    }
    
    public static void showSNT(int n)
    {
        for(int i = 2; i <= n; i++){
            int count = 0;
            for(int o = 2;o<= i/2; o++){
                if(i % o == 0){
                    count++;
                }
            }
            if(count == 0){
                Console.WriteLine("Cac so nguyen tu 1 den n la " + i );
            }
    
        }
    }
    
    public static void show(int n)
    {
        Console.WriteLine("tong = " + tinhTong(n));
    }
    public static void Main()
    {
        int n = nhapN();
        show(n);
        showSNT(n);
        checkSNT(n);
    }
}

