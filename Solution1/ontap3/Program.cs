Console.WriteLine("Nhap n: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + (i+1) + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//a
int sum = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0)
    {
        sum += arr[i];
    }
}
Console.WriteLine("Tong cac so chan trong mang la: " + sum);


int mul = 1;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 != 0)
    {
        mul *= arr[i];
    }
}
Console.WriteLine("Tich cac so le trong mang la: " + mul);

//b
int temp = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = i + 1; j < 3; j++)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
Console.Write("Sxep tang dan la: ");
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "; ");
}

