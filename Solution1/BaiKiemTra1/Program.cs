Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + (i+1) + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}

//a
int mul = 1;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 != 0)
    {
        mul *= arr[i];
    }
    else
    {
        Console.Write("Khong co so le!");
    }
}
Console.WriteLine("Tich cac so le trong mang la: " + mul);

//b
int j = 0;
int max = 0;

for (int i = 0; i < n; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
        j = i;
    }
}
int max2 = 0;
for (int i = 0; i < n; i++)
{
    if (i == j)
    {
        i++;  
        i--;
    }
    else
    {
        if (max2 < arr[i])
        {
            max2 = arr[i];
        }
    }
}

Console.Write("Phan tu lon thu hai trong mang la: " + max2);  