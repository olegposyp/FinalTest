Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day <1 || day >7)
{
Console.WriteLine($"День недели с номером {day} программе неизвестен");
}
else 
if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5) 
{
    Console.WriteLine("Это будний день");
}
else if (day == 6)
{
    Console.WriteLine("Это суббота, выходной день");
}else if (day == 7)
{
    Console.WriteLine("Это воскресенье, выходной день");
}
