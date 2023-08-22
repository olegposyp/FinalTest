System.Console.WriteLine("Введите X и Y Вашей точки");
int userx = Convert.ToInt32(Console.ReadLine());
int usery = Convert.ToInt32(Console.ReadLine());
if (userx > 0 && usery > 0)
{
    System.Console.WriteLine($"Точка {userx} : {usery} находится в первой четверти");
}
else if (userx < 0 && usery > 0)
{
    System.Console.WriteLine($"Точка {userx} : {usery} находится во второй четверти");
}
else if (userx < 0 && usery < 0)
{
    System.Console.WriteLine($"Точка {userx} : {usery} находится в третьей четверти");
}
else if (userx > 0 && usery < 0)
{
    System.Console.WriteLine($"Точка {userx} : {usery} находится в четвёртой четверти");
}