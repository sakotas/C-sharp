/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

using static System.Console;
Write("Input 1st number: ");
int NumberOne = int.Parse(ReadLine()!);
Write("Input 2nd number: ");
int NumberTwo = int.Parse(ReadLine()!);

if (NumberOne == NumberTwo)
{
    WriteLine("Numbers are equal, so max = {0}", NumberOne);  /* в условии  не указано, что делать при равенстве. Либо так вывести. Либо вывести число*/
}
if (NumberOne>NumberTwo)
{
    WriteLine("Max = {0} (First number)", NumberOne);
}
if (NumberOne<NumberTwo)
{
    WriteLine("Max = {0} (second number)", NumberTwo);
}
