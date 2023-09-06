Console.Clear();
int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }  
    return array;
}
int Positive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >0)
    {
        count++;
    }  
    }
    return count;
}
System.Console.WriteLine("Введите количество чисел, которые Вы будете вводить");
int arlength = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите числа (каждое число в новой строке)");
int[] userArray = FillArray(arlength);
System.Console.WriteLine();
System.Console.WriteLine($"Из введённых чисел {Positive(userArray)} положительных");
