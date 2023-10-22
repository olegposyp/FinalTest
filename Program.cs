// Программа получает на вход строковый массив и из исходного создаёт массив, размер элементов 
// которого не првышает 3 символов

string[] GetStringArray(int length) // Формирование массива пользователя
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите значение {i}-го элемента массива");   
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] arrayToPrint) // Печать массива
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        if (arrayToPrint[i] != " ")
        {
            Console.Write($"{arrayToPrint[i]} ");
        }
    }
    System.Console.WriteLine("]");
}

Console.Clear();
System.Console.WriteLine("Введите размер массива");
int arlength = Convert.ToInt32(Console.ReadLine());

string[] userarray = GetStringArray(arlength);
System.Console.WriteLine("Исходный массив");
PrintArray(userarray);
string[] outarray = new string[arlength];
int j = 0;
for (int i = 0; i < userarray.Length; i++)
    {
        if (userarray[i].Length < 4) 
        {
            outarray[j] = userarray[i];
            j++;
        }
    } 
System.Console.WriteLine("Преобразованный массив");
PrintArray(outarray);