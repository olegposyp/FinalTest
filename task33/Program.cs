Console.Clear();
int[] GetRandomArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}
void PrintArray(int[] arrayToPrint)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]} ");
    }
    System.Console.WriteLine("]");
}


bool FindNumber(int[] array, int usernum)
{
    bool pres = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == usernum)
        {
            System.Console.WriteLine($"Число {usernum} имеет в массиве номер {i}");
            pres = true;
            break;
        }
    }
    return pres;
}
System.Console.WriteLine("Введите размер массива");
int arlength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовые границы");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для поиска");
int usernum = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandomArray(arlength, start, end);
PrintArray(userArray);
if (FindNumber(userArray, usernum) == false)
{
    System.Console.WriteLine($"Число {usernum} в массиве отсутствует");
}
