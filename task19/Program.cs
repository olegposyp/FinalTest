System.Console.WriteLine("Введите пятизначное число");
int palin = Convert.ToInt32(Console.ReadLine());
if (palin <10000 || palin > 99999)
{
    System.Console.WriteLine("Число не пятизначное");
}
else
{int num = palin;
int vv = 0;
while (num > 10)
{
    vv = vv + num%10;
    vv = vv*10;
    num = num / 10;
}
    vv = vv + num;
if (vv == palin)
{
    System.Console.WriteLine($"Число {palin} - это палиндром");
}
else
    System.Console.WriteLine($"Число {palin} - это не палиндром");
}
