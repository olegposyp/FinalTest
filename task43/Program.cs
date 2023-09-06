/* Точка пересечения прямых имеет координаты: 
x = (b2-b1)/(k1-k2), y= k1*x+b1 */

Console.Clear();
Console.WriteLine("Введите значения коэффициентов ");
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = 1*x+b1;

Console.WriteLine();
Console.WriteLine($"Точка пересечения прямых имеет координаты x = {x}, y = {y}");
