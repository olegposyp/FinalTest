Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2*num2)
{
Console.WriteLine($"Число {num1} - это квадрат числа {num2}");
}
else if (num2 == num1*num1)
{
Console.WriteLine($"Число {num2} - это квадрат числа {num1}");
}
else Console.WriteLine($"Числа {num2} и {num1} не являются квадратами друг друга");