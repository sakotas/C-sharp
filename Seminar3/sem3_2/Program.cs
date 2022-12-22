// 18. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка

using static System.Console;

Write("input x:");

//int Number = int.Parse(ReadLine()!);
if (!int.TryParse(ReadLine(), out int X))
{
    WriteLine("Error. Input number, not string");
    return;
}

Write("input y:");
if (!int.TryParse(ReadLine(), out int Y))
{
    WriteLine("Error. Input number, not string");
    return;
}

// if ( X > 0 && Y > 0)
// {
//     WriteLine ("1 chetv");
// }
// if ( X > 0 && Y < 0)
// {
//     WriteLine ("4 chetv");
// }
// if ( X < 0 && Y > 0)
// {
//     WriteLine ("2 chetv");
// }
// if ( X < 0 && Y < 0)
// {
//     WriteLine ("3 chetv");
// }

if (X > 0)
{
    if (Y > 0)
    {
        WriteLine ("First quarter");
    }
    else
    {
        WriteLine("forth quarter");
    }
}
    if (X < 0)
{
    if (Y > 0)
    {
        WriteLine ("second quarter");
    }
    else
    {
        WriteLine("Third quarter");
    }
}


