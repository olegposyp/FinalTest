Console.Clear();
int[] FillUserArray()
{
    int[] array = new int[3];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
bool TriExist(int[] array)
{
        if (array[0]+array[1]>array[2] && array[0]+array[2]>array[1] && array[0]+array[2]>array[1])
    {
        return true;
    }
    else 
    return false;
}
System.Console.WriteLine("Введите длины сторон треугольника");
int[] userArray = FillUserArray();
bool result = TriExist(userArray);
System.Console.WriteLine();
if (result==true)
{
    System.Console.WriteLine("Треугольник c такими длинами сторон существует");
}
else
System.Console.WriteLine("Tреугольник c такими длинами сторон не существует");