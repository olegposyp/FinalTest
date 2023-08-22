System.Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    System.Console.WriteLine($"Точки в четверти {num} имеют координаты: X > 0, Y > 0 ");
}
else if (num == 2)
{
    System.Console.WriteLine($"Точки в четверти {num} имеют координаты: X < 0, Y > 0 ");
}
else if (num == 3)
{
    System.Console.WriteLine($"Точки в четверти {num} имеют координаты: X < 0, Y < 0 ");
}
else if (num == 4)
{
    System.Console.WriteLine($"Точки в четверти {num} имеют координаты: X > 0, Y < 0 ");
}
else 
{
    System.Console.WriteLine($"Такой четверти не существует");
}