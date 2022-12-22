// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using static System.Console;
Clear();

Write("Input 3 digit number: ");
int Number = int.Parse(ReadLine()!);

int SecondDigit = (Math.Abs(Number) - (Math.Abs(Number) / 100) * 100) / 10;
WriteLine("Second digit = {0}", SecondDigit);
