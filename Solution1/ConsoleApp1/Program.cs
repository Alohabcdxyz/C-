// Console.Write("Nhap a: ");
// int a = int.Parse(Console.ReadLine());
// if (a > 0)
// {
//     Console.WriteLine(a + "la so duong");
// }
// else if (a < 0)
// {
//     Console.WriteLine(a + "la so am");
// }
// else
// {
//     Console.WriteLine("ko am ko duong");
// }

//Bai1
Console.Write("Nhap a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Nhap b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Nhap c: ");
int c = int.Parse(Console.ReadLine());
if ((a + b) > c || (b + c) > a || (a + c) > b)
{
    Console.WriteLine("Day la tam giac");
}
if ((a == b) || (b == c) || (c == a))
{
    Console.WriteLine("Day la tam giac can");
} else if ((a == b) && (b == c) && (c == a))
{
    Console.WriteLine("Day la tam giac deu");
}else if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == b * b + a * a))
{
    Console.WriteLine("Day la tam giac vuong");
    }
    else
{
    Console.WriteLine("Day ko la tam giac");
}

//Bai2
Console.Write("Nhap d: ");
int d = int.Parse(Console.ReadLine());
Console.Write("Nhap f: ");
int f = int.Parse(Console.ReadLine());
Console.Write("Nhap e: ");
int e = int.Parse(Console.ReadLine());
if(((f*f) - (4*d*e)) > 0){
    Console.WriteLine("Co 2 no");
}else if(((f*f) - (4*d*e)) == 0){
    Console.WriteLine("Co 1 no");
}
else
{
    Console.WriteLine("Vo no");
}