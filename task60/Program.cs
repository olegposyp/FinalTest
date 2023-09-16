Console.Clear();

int[,] GetRandom2DArray(int rownumber, int colnumber, int deviation)
{
    int[,] result = new int[rownumber,colnumber];
        for (int i = 0; i < rownumber; i++)
        {
            for (int j = 0; j < colnumber; j++)
            {
                result[i,j] = new Random().Next(0, deviation);
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

int[] MinSum(int[,] array)   
    {
    int raws = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] sumN = new int[2];
    for (int i = 0; i < cols; i++)
    {
        sumN[0] += array[0,i]; 
    }
    for (int i = 0; i < raws; i++)
    {
        int sumT = 0;
        for (int j = 0; j < cols; j++)
            {
                sumT += array[i,j]; 
            }
        if (sumT < sumN[0])
            {
                sumN[0] = sumT;
                sumN[1] = i;
            }
        }
    return sumN;    
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
int[] sumN = MinSum(randomArray);
System.Console.WriteLine($"Наименьшую сумму {sumN[0]} имеет строка {sumN[1]}");

