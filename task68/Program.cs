Console.Clear();


int Ackermann(int m, int n)
{
    if (m <0 || n < 0) 
    {
        System.Console.WriteLine("M и N должны быть неотрицательными");        
    }
    if (m == 0) return n+1;
    if (n == 0) return Ackermann(m-1, 1);
     return Ackermann(m-1, Ackermann(m,n-1));
}
System.Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Значение функции Акерманна для чисел {m} и {n} равно {Ackermann(m, n)}");
