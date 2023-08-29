int SumOfNumber(int number)
{
    int sum=0;
for (int i=1; i<=number; i++)
{
    sum += i;
}
return sum;
}
System.Console.WriteLine("Введите число");
int usernumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {usernumber} равна {SumOfNumber(usernumber)}");