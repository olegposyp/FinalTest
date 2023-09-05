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

int[] ChangeArray(int[] array)
{
    int temp = 0;
    int count = array.Length-1;
    for(int i = 0; i< array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[count];
        array[count] = temp;
        count--;
    }
    return array;
}
System.Console.WriteLine("Введите размер массива");
int arlength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовые границы");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor=ConsoleColor.Blue;
int[] userarray = GetRandomArray(arlength, start, end);
PrintArray(userarray);
System.Console.WriteLine();
int[] changedArray = ChangeArray(userarray);
Console.ForegroundColor=ConsoleColor.Green;
PrintArray(changedArray);
Console.ForegroundColor=ConsoleColor.White;