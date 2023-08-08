Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 7;
int num2 = 23;

if (num % num1 == 0 & num % num2 == 0)
{
    Console.WriteLine($"Число {num} кратно числам {num1} и {num2}");
}
else
{
    Console.WriteLine($"Число {num} не кратно числам {num1} и {num2}");
}