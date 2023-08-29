int QuanOfFigures(int number)
{
    int sum=0;
    while (number>0)
    {
    sum ++;
    number = number/10;
}
return sum;
}
System.Console.WriteLine("Введите число");
int usernumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Колоичество цифр в числе {usernumber} равна {QuanOfFigures(usernumber)}");