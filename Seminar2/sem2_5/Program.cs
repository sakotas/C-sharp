/* **Задача 14:**

Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.

14  ->  нет
46  ->  нет
161 ->  да
*/

using static System.Console;

Write("Input the number: ");
int Number = int.Parse(ReadLine()!);

if ((Number % 7 == 0) && (Number % 23 == 0))
{
    WriteLine("YES");
}
else
{
    WriteLine("NO!");
}