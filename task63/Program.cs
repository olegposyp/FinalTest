Console.Clear();
string numb = string.Empty;

void NatNum(int end)
{
    if (end == 1 ) numb = "1"+numb;
else 
    {
    numb = Convert.ToString(end)+" "+numb;
    NatNum(end-1);
    }
}

System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
NatNum(n);
System.Console.WriteLine(numb);