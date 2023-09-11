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

int GetSumOdd(int[] array)
{
    int sumOdd = 0;
    for(int i = 0; i< array.Length; i += 2)
    {
       sumOdd += array[i];
    }
    return sumOdd;
}
System.Console.WriteLine("Введите размер массива");
int arlength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовые границы");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());

int[] userarray = GetRandomArray(arlength, start, end);
PrintArray(userarray);
System.Console.WriteLine();
int usersumOdd = GetSumOdd(userarray);
System.Console.WriteLine($"Сумма чисел на нечётных позициях в массиве равна {usersumOdd}");