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
int[] Coord(int[,] array)   
    {
    int raws = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] result = new int[2]; 
    int min = array[0,0];
    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < cols; j++)
        {
        if (array[i,j] < min)
        {
            min = array[i,j];
            result[0] = i;
            result[1] = j;
        }
        }
    }
    return result;
    }
int[,] DeleteCross(int[,] array, int[] coord)
{
    int raws = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] del = new int[raws-1,cols-1]; 
        for (int i = 0; i < coord[0]; i++)
        {   
            for (int j = 0; j < coord[1]; j++)
                {
                    del[i,j] = array[i,j];
                }
            for (int j = coord[1]; j <cols-1; j++)
                {
                    del[i,j] = array[i,j+1];
                }
        }
        for (int i = coord[0]; i < raws-1; i++)
        {   
            for (int j = 0; j < coord[1]; j++)
                {
                    del[i,j] = array[i+1,j];
                }
            for (int j = coord[1]; j < cols-1; j++)
                {
                    del[i,j] = array[i+1,j+1];
                }
        }
         return del;
}
System.Console.WriteLine("Введите количество строк");
int raws = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон чисел");
int deviation = Convert.ToInt32(Console.ReadLine());
int[,] initArray = GetRandom2DArray(raws,cols,deviation);
Console.WriteLine("Исходный массив");
Print2DArray(initArray);
Console.WriteLine();
int[] coor = Coord(initArray);
Console.WriteLine("Массив с удалёнными строкой и столбцом");
int[,] del = DeleteCross(initArray, coor);
Print2DArray(del);