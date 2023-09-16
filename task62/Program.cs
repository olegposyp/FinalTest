Console.Clear();

int[,] FilSpir(int rows, int cols)
{
    int[,] result = new int[rows,cols];
    int fin = rows*cols;
    int right = rows-1;
    int bot = cols-1;
    int left = 0;
    int up = 1;
    int dir = 1;
    int x = 0;
    int y = 0;

        for (int i = 0; i <= fin; i++)
        {
            result[y,x] = i;
            Print2DArray(result,y,x);
            if (dir == 1 && x < right) x++;
            else if (dir == 1 && x == right) 
            {
                dir = 2; 
                right--;
            }
            if (dir == 2 && y < bot) y++;
            else if (dir == 1 && y == bot) 
            {
                dir = 3; 
                bot--;
            }
            if (dir == 3 && x > left) x--;
            else if (dir == 1 && x == left) 
            {
                dir = 4; 
                left++;
            }
            if (dir == 4 && y > up) y--;
            else if (dir == 4 && y == up) 
            {
                dir = 1; 
                up++;
                x++;
            }
        }
    return result;
}
void Print2DArray(int[,] arrayToPrint,int y, int x)
{
    int raws = arrayToPrint.GetLength(0);
    int cols = arrayToPrint.GetLength(1);
    Console.SetCursorPosition(0,0);
   
    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < cols; j++)
        if (j == x && i == y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(arrayToPrint[i,j]+"\t");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if(arrayToPrint[i,j] !=0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(arrayToPrint[i,j]+"\t");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.Write(arrayToPrint[i,j]+"\t");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Введите количество строк");
int raws = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[,] spir = FilSpir(raws,cols);
 