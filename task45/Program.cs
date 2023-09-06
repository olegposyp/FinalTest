Console.Clear();
int[] FillArray(int length)
{
    int[] array = new int[length];
    Console.WriteLine("Введите значения элементов массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Элемент массива с номером {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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
int[] Copy(int[] array, int length)
{
    int[] copyArray = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
} 

Console.WriteLine("Задайте количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] userArray = FillArray(length);
Console.WriteLine("Вы задали массив: ");
PrintArray(userArray);
Console.WriteLine("Копия массива:");
int[] copy = Copy(userArray, length);
PrintArray(copy);