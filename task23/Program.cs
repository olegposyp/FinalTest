System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int cube = 0;
while (count < num)
{
    count++;
    cube = count*count*count;
    System.Console.Write($"{cube} ,");
}

