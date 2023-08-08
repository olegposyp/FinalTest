int num = new Random().Next(100,1000);
Console.WriteLine(num);
int n1 = num/100;
int n2 = num%10;
int res = n1*10+n2;
    Console.WriteLine(res);

