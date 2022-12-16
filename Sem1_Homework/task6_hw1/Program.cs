/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

using static System.Console;

Write("Input the number: ");
int Number = int.Parse(ReadLine()!);

if (Number == 0 || Number % 2 == 0)
{
    WriteLine("Yes, number is Even");
}
else
{
    WriteLine("NO, numbe is odd");
}
