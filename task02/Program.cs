Console.WriteLine("Введите первое число: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberb = Convert.ToInt32(Console.ReadLine());
if (numbera > numberb)
{
    Console.WriteLine("Первое число: " + numbera + " больше, чем второе: " + numberb);
}
else if (numbera < numberb)
{
    Console.WriteLine("Первое число: " + numbera + " меньше, чем второе: " + numberb);
}
else Console.WriteLine("Числа равны");