
//a
Console.WriteLine("Nhap n: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
int maxx = arr[0];
for(int i = 0; i<n;i++)
{
    if(arr[i] > maxx) maxx = arr[i];
}

int minn = arr[0];
for(int i = 0; i<n;i++)
{
    if(arr[i] < minn) minn = arr[i];
}
Console.WriteLine("Max la: " + maxx + " Min la: " + minn);

//b
int giamDan;
for(int i = 0; i < n - 1; i++){
    for(int j = i + 1; j < n; j++){
        if(arr[i] < arr[j]){
            giamDan = arr[i];
            arr[i] = arr[j];
            arr[j] = giamDan;        
        }
    }
}

Console.Write("Mang theo thu tu giam dan la: ");
for(int i = 0; i < n; i++){
    Console.Write(arr[i] + " ; ");
}