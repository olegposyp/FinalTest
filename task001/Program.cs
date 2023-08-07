Console.WriteLine("Введите 2 числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.Write("Число "); Console.Write(number1); Console.Write(" является квадратом числа "); Console.WriteLine(number2);
}
else
    Console.Write("Число "); Console.Write(number1); Console.Write(" не является квадратом числа "); Console.WriteLine(number2);
