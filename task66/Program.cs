Console.Clear();

int sum = 0;
void NatSumSp(int m, int n)
{
    if (m <= n) 
    {
        sum = sum+m;
        NatSumSp(m+1, n);
        }
}

System.Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
NatSumSp(m,n);
System.Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");