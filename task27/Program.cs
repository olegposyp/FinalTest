Console.Clear();
int SumOfFigures(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number%10;
        number = number/10;
    }
    return sum;
}
System.Console.WriteLine("Введите число");
int usernumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {usernumber} равно {SumOfFigures(usernumber)}");
