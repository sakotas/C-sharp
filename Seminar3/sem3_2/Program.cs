// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

using static System.Console;
Clear();

WriteLine("Input one-digit number from 1 to 7: ");
int num = int.Parse(ReadLine()!);

switch (num)
{
    case 1:
        {
            WriteLine("Нет");
            break;
        }
    case 2:
        {
            WriteLine("Нет");
            break;
        }
    case 3:
        {
            WriteLine("Нет");
            break;
        }
    case 4:
        {
            WriteLine("Нет");
            break;
        }
    case 5:
        {
            WriteLine("Нет");
            break;
        }
    case 6:
        {
            WriteLine("Да");
            break;
        }
    case 7:
        {
            WriteLine("Да");
            break;
        }
    default:
        {
            WriteLine($"You entered wrong number, {num} is out of range from 1 to 7");
            break;
        }

}