// **Задача 16:**

// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

using static System.Console;
Clear();
WriteLine("Input number 1: ");
int num1 = int.Parse(ReadLine()!);

WriteLine("Input number 2: ");
int num2 = int.Parse(ReadLine()!);

// if ((num1 * num1 == num2) || (num2 * num2 == num1))
// {
//     WriteLine("YES");
// }
// else
// {
//     WriteLine("No");

// }

WriteLine((num1 * num1 == num2) || (num2 * num2 == num1)?"Yes":"No");