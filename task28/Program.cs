int ProdOfNumber(int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
    {
        prod *= i;
    }
    return prod;
}
System.Console.WriteLine("Введите число");
int usernumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел до числа {usernumber} равно {ProdOfNumber(usernumber)}");