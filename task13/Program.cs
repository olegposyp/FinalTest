Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1%num2 == 0)
{
Console.WriteLine($"Число {num1} кратно числу {num2}");
}
else 
{
    Console.Write($"Число {num1} не кратно числу {num2} ");
    int num3 = num1%num2;
    Console.WriteLine($"Остаток деления - {num3}");
}