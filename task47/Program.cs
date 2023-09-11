Console.Clear();

double[,] GetRandom2DDobleArray(int rownumber, int colnumber)
{
    double[,] result = new double[rownumber,colnumber];
        for (int i = 0; i < rownumber; i++)
        {
            for (int j = 0; j < colnumber; j++)
            {
                result[i,j] = (new Random().NextDouble()*20-10);
            }
        }
    return result;
}
void Print2DArray(double[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        System.Console.Write($"{  (i)}\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {
            System.Console.Write($"{(i)}\t");
            for (int j = 0; j < arrayToPrint.GetLength(1); j++)
            {
                System.Console.Write(System.Math.Round(arrayToPrint[i,j],2)+"\t");
            }
        Console.WriteLine();
        }
        
}

double[,] randomArray = GetRandom2DDobleArray(5,5);
Print2DArray(randomArray);

