Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Nhap so thu " + (i + 1) + ": ");
    arr[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0)
    {
        sum += arr[i];
    }
}
Console.Write("Tong cac so chan la: " + sum);

