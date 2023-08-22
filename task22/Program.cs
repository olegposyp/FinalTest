System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int sq = 0;
while (count < num)
{
    count++;
    sq = count*count;
    System.Console.Write(sq);
}

