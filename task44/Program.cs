Console.Clear();
System.Console.WriteLine("Введите неотрицательное целое число");
int fib = Convert.ToInt32(Console.ReadLine());
int[] array = new int[fib];
void Fibonacci(int[] array)
{
    array [0] = 1;
    System.Console.Write(array[0]+" ");
    if (array.Length >1)
    {
        array[1] = 1;
        System.Console.Write(array[1]+" ");
    }
    if (array.Length >2)
    {
        for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1]+array[i-2];
        Console.Write($"{array[i]} ");
    }  
    }
}
    System.Console.WriteLine();
    Fibonacci(array);
