Console.Clear();

int[,] GetRandom2DArray(int rownumber, int colnumber, int deviation)
{
    int[,] result = new int[rownumber,colnumber];
        for (int i = 0; i < rownumber; i++)
        {
            for (int j = 0; j < colnumber; j++)
            {
                result[i,j] = new Random().Next(-deviation, deviation);
            }
        }
    return result;
}
void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        System.Console.Write($"{(i)}\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {
            System.Console.Write($"{(i)}\t");
            for (int j = 0; j < arrayToPrint.GetLength(1); j++)
            {
                System.Console.Write(arrayToPrint[i,j]+"\t");
            }
        Console.WriteLine();
        }     
}

int[,] ChangeArray(int[,] array)   
    {
    int raws = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < raws; i++)
    {
        int temp = array[i,0];
        for (int j = 1; j < cols; j++)
        {
            for (int k = j; k > 0; k--)
            {
                if (array[i,k] > array[i,k-1])
                {
                temp = array[i,k-1];
                array[i,k-1] = array[i,k];
                array[i,k] = temp;
                }
            }
        }
    }    
    return array;
    }
    
System.Console.WriteLine("Введите количество строк");
int raws = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон чисел");
int deviation = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = GetRandom2DArray(raws, cols,deviation);
System.Console.WriteLine("Исходный массив");
Print2DArray(randomArray);
int[,] change = ChangeArray(randomArray);
System.Console.WriteLine("Отсортированный массив");
Print2DArray(change);

