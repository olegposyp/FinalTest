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
void CheckArray(int[,] array, int i, int j)   
    {
    int raws = array.GetLength(0);
    int cols = array.GetLength(1);
    int num = 0;
    if (i > raws || i < 0 || j < 0 || j > cols)
    {
        System.Console.WriteLine("Элемента с такими координатами в массиве нет");
        
    }
    else
    {
        System.Console.WriteLine($"Элемент с координатами {i} {j} в массиве имеет значение {array[i,j]}");

    }
     
    }
    
int[,] randomArray = GetRandom2DArray(5,5,10);
Print2DArray(randomArray);
System.Console.WriteLine("Введите номер строки");
int ius = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите номер столбца");
int jus = Convert.ToInt32(System.Console.ReadLine());
CheckArray(randomArray, ius, jus);