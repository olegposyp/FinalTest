int sum = SumNumber(256);
int SumNumber(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else
    return n%10+SumNumber(n/10);
}
Console.WriteLine(sum);