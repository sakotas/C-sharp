/* Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа 
в промежутке от -N до N.

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"

*/


using static System.Console;
Write("Input number: ");
int number = int.Parse(ReadLine()!);

int start = -number;
while (start < number)
{
    Write($" {start},");
    start +=1;
}
WriteLine($" {start}");
