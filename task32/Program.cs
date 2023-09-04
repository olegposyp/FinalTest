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

int[] ChangeSignArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
     array[i]*=-1;  
    }
    return array;
}
Console.WriteLine("Введите размер массива");
int userlength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовые границы");
int userstart = Convert.ToInt32(Console.ReadLine());
int userend = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandomArray(userlength,userstart,userend);
PrintArray(userArray);
PrintArray(ChangeSignArray(userArray));
