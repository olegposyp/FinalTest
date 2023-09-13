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
    System.Console.WriteLine();
}

int[,] MatrPro(int[,] matr1, int[,] matr2)   
    {
    int raws = matr1.GetLength(0);
    int cols = matr1.GetLength(1);
    int[,] proM = new int[raws,cols];
    
    for (int i = 0; i < raws; i++)
    {
        int sumT = 0;
        for (int j = 0; j < cols; j++)
            {
                proM[i,j] = matr1[i,j]*matr2[i,j]; 
            }
        }
    return proM;    
    }
    
System.Console.WriteLine("Введите количество строк в матрицах");
int raws = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрицах");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон чисел");
int deviation = Convert.ToInt32(Console.ReadLine());
int[,] matr1 = GetRandom2DArray(raws, cols,deviation);
int[,] matr2 = GetRandom2DArray(raws, cols,deviation);
System.Console.WriteLine("Исходные матрицы");
Print2DArray(matr1);
Print2DArray(matr2);
int[,] proM = MatrPro(matr1,matr2);
System.Console.WriteLine($"Произведение матриц");
Print2DArray(proM);

