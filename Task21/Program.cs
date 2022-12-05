//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Введите x1 ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y1 ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите x2 ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y2 ");
double y2 = double.Parse(Console.ReadLine());
double xdiff = x1 - x2;
double ydiff = y1 - y2;
double xdiff2 = Math.Pow(xdiff, 2);
double ydiff2 = Math.Pow(ydiff, 2); 
double d = Math.Sqrt(xdiff2 + ydiff2);
Console.WriteLine($"d={d:f2}");