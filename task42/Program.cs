Console.WriteLine("Введите число");
string ConvBin(int num)
{
    string result = String.Empty;
    int temp = 0;
    for (int i = num; i > 0; i/=2)
    {
        temp = i%2;
        result = temp + result;
    }
    return result;
}
int usnum = Convert.ToInt32(Console.ReadLine());

string converted = ConvBin(usnum);
Console.WriteLine($"Число {usnum} в двоичной форме {converted}");