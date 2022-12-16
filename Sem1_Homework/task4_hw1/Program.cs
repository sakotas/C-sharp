/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using static System.Console;

Write("Input 1st number: ");
int NumberOne = int.Parse(ReadLine()!);

Write("Input 2nd number: ");
int NumberTwo = int.Parse(ReadLine()!);

Write("Input 3rd number: ");
int NumberThree = int.Parse(ReadLine()!);



int max = NumberOne;
if (NumberTwo > max)
{
    max = NumberTwo;
}
if (NumberThree > max)
{
    max = NumberThree;
}

//WriteLine(max);
WriteLine("Max naumber is: {0} ", max);
