Console.WriteLine("Bai 1");
Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine());
int count = 0;
// a
int m = 1;
for(int i=1;i<=n;i++){  
    m = m*i;
}  
Console.WriteLine("Giai thua cua " + n + " = " + m);


//c

for(int k = 2; k <= n; k++){
    count = 0;
    for(int o = 2;o<= k/2; o++){
        if(k % o == 0){
            count++;
        }
    }        
    if(count == 0){
        Console.WriteLine("Cac so nguyen tu 1 den n la " + k);
    }
}

