Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
if (num < 100 || num > 999)
{
    Console.WriteLine($"Число {num} - не трёхзначное");
}
else
{
    num1 = num / 10;
num1 = num1 % 10;
Console.WriteLine($"Вторая цифра числа {num} - это {num1}");
}