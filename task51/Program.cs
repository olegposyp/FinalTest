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
int DiagSum(int[,] array)   
    {
    int raws = array.GetLength(0);
    int cols = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < raws; i++)
    {
    for (int j = 0; j < cols; j++)
        {
            if (i == j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
    }
int[,] randomArray = GetRandom2DArray(5,6,10);
Print2DArray(randomArray);
System.Console.WriteLine($"Сумма чисел главной диагонали равна {DiagSum(randomArray)}");

