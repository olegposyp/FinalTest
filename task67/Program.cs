
int SumNumber(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else
    return n%10+SumNumber(n/10);
}
System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNumber(n);
Console.WriteLine(sum);