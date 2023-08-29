Console.Clear();
int DegreeOfNumber(int number, int degree)
{
    int numdeg = number;
    for (int i = 1; i < degree; i++)
    {
        numdeg *= number;
    }
    return numdeg;
}
System.Console.WriteLine("Введите два числа");
int usernumber1 = Convert.ToInt32(Console.ReadLine());
int usernumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {usernumber1} в степени {usernumber2} равно {DegreeOfNumber(usernumber1,usernumber2)}");
