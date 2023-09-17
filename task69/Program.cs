
int Degree(int m,int n)
{
    if (n == 1)
    {
        return m;
    }
    else
    return m*Degree(m,n-1);
}
Console.Clear();
System.Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int deg = Degree(m,n);
Console.WriteLine($"Число {m} в степени {n} равно {deg}");
