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
    int[,] change = new int[raws,cols]; 
    int temp = 0;
    for (int i = 0; i < raws; i++)
    {
        for (int j = i; j < cols; j++)
        {
        temp = array[i,j];
        array[i,j] = array[j,i];
        array[j,i] = temp;   
        }
    }
    return array;
    }
    
int[,] randomArray = GetRandom2DArray(5,5,10);
Print2DArray(randomArray);
int[,] change = ChangeArray(randomArray);
System.Console.WriteLine();
Print2DArray(change);
