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

int GetEven(int[] array)
{
    int even = 0;
    for(int i = 0; i< array.Length; i++)
    {
        if (array[i] %2 == 0)
        even++;
    }
    return even;
}
System.Console.WriteLine("Введите размер массива");
int arlength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовые границы (числа должны быть трёхзначными)");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());

int[] userarray = GetRandomArray(arlength, start, end);
PrintArray(userarray);
System.Console.WriteLine();
int even = GetEven(userarray);
System.Console.WriteLine($"Количество чётных чисел в массиве равно {even}");