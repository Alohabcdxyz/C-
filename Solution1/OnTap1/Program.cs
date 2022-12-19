Console.WriteLine("Nhap n: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + (i+1) + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//a
int maxx = arr[0];
for(int i = 0; i<n;i++)
{
    if (arr[i] > maxx)
    {
        maxx = arr[i];
    }
}
Console.WriteLine("Phan tu lon nhat la " + maxx);

int giai_thua = 1;
for (int i = 1; i <= maxx; i++)
{
    giai_thua = giai_thua * i;
}
Console.WriteLine("Giai thua cua " + maxx + " la: " + giai_thua);


//b

int j = 0;
int min2 = 0; 
for (int i = 0; i < n; i++)
{
    if (i == j)
    {
        i++;  
        i--;
    }
    else
    {
        if (min2 > arr[i])
        {
            min2 = arr[i];
        }
    }
}

Console.Write("Phan tu nho thu hai trong mang la:  {0} ", min2);       


