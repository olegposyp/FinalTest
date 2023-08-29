Console.Clear();
int[] GetRandomArray()
{
    int[] array = new int[8] ;
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}
void PrintArray(int[] arrayToPrint)
{
    System.Console.Write("[ ");
    for(int i = 0; i< arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]} ");
    }
    System.Console.WriteLine("]");
}
int[] userArray = GetRandomArray();
PrintArray(userArray);
