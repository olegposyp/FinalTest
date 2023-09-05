Console.Clear();
double[] GetRandomArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*100;
    }
    return array;
}
void PrintArray(double[] arrayToPrint)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayToPrint[i],2)+"|");
    }
    System.Console.WriteLine("]");
}

double GetMax(double[] array)
{
    double max = array[0];
    for(int i = 0; i< array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double GetMin(double[] array)
{
    double min = array[0];
    for(int i = 0; i< array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
System.Console.WriteLine("Введите размер массива");
int arlength = Convert.ToInt32(Console.ReadLine());

double[] userarray = GetRandomArray(arlength);
PrintArray(userarray);
System.Console.WriteLine();
double dif = GetMax(userarray)-GetMin(userarray);
System.Console.Write("Разность максимального и минимального членов массива равна ");
System.Console.WriteLine("{0:0.00}",dif);