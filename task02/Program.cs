Console.WriteLine("Введите первое число:");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberb = Convert.ToInt32(Console.ReadLine());
if (numbera > numberb)
{
    Console.WriteLine("Число: " + numbera + " больше числа " + numberb);
}
else
if (numbera < numberb)
{
    Console.WriteLine("Число: " + numberb + " больше числа " + numbera);
}
else
{
    Console.WriteLine("Числа равны");
}