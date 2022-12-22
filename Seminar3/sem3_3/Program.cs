// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка

// if (i == 1)
// {
//     WriteLine("x>0 y>0");
// }
// if (i == 2)
// {
//     WriteLine("x<0 y<0");
// }
// if (i == 3)
// {
//     WriteLine("x<0 y>0");
// }
// if (i == 4)
// {
//     WriteLine("x>0 y<0");
// }

using static System.Console;
Clear();

Write("Координату 'x': ");
int x = int.Parse(ReadLine()!);

Write("Координату 'y': ");
int y = int.Parse(ReadLine()!);

if (x > 0 && y > 0)
{
    WriteLine("1я четверть");
    return;
}
if (x < 0 && y < 0)
{
    WriteLine("2я четверть");
    return;
}
if (x < 0 && y > 0)
{
    WriteLine("3я четверть");
    return;
}
if (x > 0 && y < 0)
{
    WriteLine("4я четверть");
    return;
}
