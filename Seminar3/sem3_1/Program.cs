// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

using static System.Console;
Clear();

WriteLine("Введите номер четверти:");
int i = int.Parse(ReadLine()!);

// if(i < 1 || i > 4)
// {
//     WriteLine("Ошибка");
//     return;
// }
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

switch (i)
{
    case 1:
        {
            WriteLine("x>0 y>0");
            break;
        }
    case 2:
        {
            WriteLine("x<0 y<0");
            break;
        }
    case 3:
        {
            WriteLine("x<0 y>0");
            break;
        }
    case 4:
        {
            WriteLine("x>0 y<0");
            break;
        }
    default:
        {
            WriteLine("Ошибка");
            break;
        }

}

