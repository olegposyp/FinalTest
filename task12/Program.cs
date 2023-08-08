Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
if (num1 < 0)
{
    num1 = -num1;
}
if (num < 100 & num > -100)
{
    Console.WriteLine($"Число {num} не имеет третьей цифры");
}
else
{
    while (num1 > 1000)
    {
        num1 = num1 / 10;
    }
    num1 = num1 % 10;

    Console.WriteLine($"Третья цифра числа {num} - это {num1} ");
}