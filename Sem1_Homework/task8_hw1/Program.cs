/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

using static System.Console;

Write("Input the number: ");
int Number = int.Parse(ReadLine()!);

int Count = 1;

while (Count <= Number)
{
    if (Count % 2 == 0)
    {
        Write("{0} ", Count);
    }
    Count += 1;
}

WriteLine("");