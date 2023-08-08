int num = new Random().Next(10,100);
Console.WriteLine(num);
int n1 = num/10;
int n2 = num%10;
if (n1>n2)
{
    Console.WriteLine($"Наибольшая цифра числа {num} - {n1}");
}
else Console.WriteLine($"Наибольшая цифра числа {num} - {n2}");
if (n1==n2)
{
    Console.WriteLine($"Обе цифры одинаковы {n1}");
}