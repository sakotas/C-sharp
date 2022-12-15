//1. Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго.
//
//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет

using static System.Console;
Write ("Input first number: ");
int a = int.Parse(ReadLine()!);
Write ("Input second number: ");
int b = int.Parse(ReadLine()!);

if ((b * b) == a)
    {
        WriteLine("YES");
    }
else
{
    WriteLine("NO");
}

