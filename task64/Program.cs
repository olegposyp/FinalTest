Console.Clear();
string numb = string.Empty;

void NatNum(int end)
{   
    if (end>0) 
    {
    numb = numb+" "+Convert.ToString(end);
    NatNum(end-1);
    }
}

System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
NatNum(n);
System.Console.WriteLine(numb);