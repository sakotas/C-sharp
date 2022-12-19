// Задача 14:
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

using static System.Console;
Clear();

WriteLine("Input number: ");
int num = int.Parse(ReadLine()!);

// if ((num % 7 == 0) && (num % 23 == 0))
// {
//     WriteLine("Да");
// }
// else
// {
//     WriteLine("Нет");
// }
WriteLine((num % 7 == 0) && (num % 23 == 0)?"Да":"Нет");