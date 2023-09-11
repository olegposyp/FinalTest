Console.Clear();

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i,j] = i+j;
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
 
int[,] userArray = GetArray(3,4);
Print2DArray(userArray);
