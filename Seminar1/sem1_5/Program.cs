/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
     456 -> 6
     782 -> 2
     918 -> 8
    */

using static System.Console;
Write("Input 3 digit number: ");
int number = int.Parse(ReadLine()!);

if (number>99 && number <1000)
{
    int result = number %10;
    WriteLine($"Last digit = {result} ");
}
else
{
    WriteLine("Out of range");
}
