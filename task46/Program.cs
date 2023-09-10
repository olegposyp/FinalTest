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
    
int[,] randomArray = GetRandom2DArray(5,5,10);
Print2DArray(randomArray);
