Console.Clear();
string numb = string.Empty;

void NatSpace(int m, int n)
{
    if (m < n) 
    {
        System.Console.Write(m+" ");
    NatSpace(m+1, n);
    }
}

System.Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
NatSpace(m,n);
System.Console.WriteLine();