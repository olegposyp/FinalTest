Console.WriteLine("Введите первое число: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberc = Convert.ToInt32(Console.ReadLine());

int max = numbera;
int eq = 0;
int eq1 = 0;

if (numbera < numberb)
{
    max = numberb;
}
else if (numbera == numberb)
{
    eq = 1;
}
if (max < numberc)
{
    max = numberc;
}
else if (max == numberc)
{ 
    eq1 = 1;
}

if (eq + eq1 < 1)
{
    Console.WriteLine("Наибольшее число: " + max);
}
else if (eq + eq1 < 2)
{
    Console.WriteLine("Два наибольших числа: " + max);
}
else Console.WriteLine("Все три числа равны: " + max);
