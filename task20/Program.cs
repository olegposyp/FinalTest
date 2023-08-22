System.Console.WriteLine("Введите X и Y первой точки");
int userx1 = Convert.ToInt32(Console.ReadLine());
int usery1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите X и Y второй точки");
int userx2 = Convert.ToInt32(Console.ReadLine());
int usery2 = Convert.ToInt32(Console.ReadLine());
double dist = Math.Sqrt(((userx1-userx2)*(userx1-userx2)+(usery1-usery2)*(usery1-usery2)));
double distrnd = Math.Round (dist,2);
System.Console.WriteLine($"Расстояние между точками с координатами {userx1} : {usery1} и {userx2} : {usery2} равно {distrnd}");
