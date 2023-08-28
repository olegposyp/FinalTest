System.Console.WriteLine("Введите координаты X, Y и Z первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите X, Y и Z второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
double dist = Math.Sqrt(((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (y1 - y2) + (z1 - z2)));
double distrnd = Math.Round(dist, 2);
System.Console.WriteLine($"Расстояние между точками с координатами {x1} : {y1} : {z1} и {x2} : {y2} : {z2} равно {distrnd}");

