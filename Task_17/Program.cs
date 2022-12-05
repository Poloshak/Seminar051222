//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();
Console.WriteLine("Введите координаты x ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y ");
int y = int.Parse(Console.ReadLine());
if(x>0 && y>0)
{
    Console.WriteLine ("Первая четверть плоскости");
}
if(x<0 && y>0)
{
    Console.WriteLine ("Вторая четверть плоскости");
}
if(x<0 && y<0)
{
    Console.WriteLine ("Третья четверть плоскости");
}
if(x>0 && y<0)
{
    Console.WriteLine ("Четвертая четверть плоскости");
}
if (x==0 || y==0)
{
    Console.WriteLine ("На оси");
}
