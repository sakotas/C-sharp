﻿// **Задача 16:**

// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

using static System.Console;
Clear();
WriteLine("Input number 1: ");
int num1 = int.Parse(ReadLine()!);

WriteLine("Input number 2: ");
int num2 = int.Parse(ReadLine()!);

WriteLine(num1 * num1 == num2?
            $"Второе число '{num2}' является квадратом первого числа '{num1}'":
            num2 * num2 == num1?
            $"Первое число '{num1}' является квадратом второго числа '{num2}'":
            "Ни одно число не является квадратом другого");

// if (num1 * num1 == num2)
// {
//     WriteLine($"Второе число '{num2}' является квадратом первого числа '{num1}'");
// }
// else if (num2 * num2 == num1)
// {
//     WriteLine($"Первое число '{num1}' является квадратом второго числа '{num2}'");

// }
// else
// {
//     WriteLine("Ни одно число не является квадратом другого");
// }

WriteLine(num1 * num1 == num2?
            $"Второе число '{num2}' является квадратом первого числа '{num1}'":
            num2 * num2 == num1?
            $"Первое число '{num1}' является квадратом второго числа '{num2}'":
            "Ни одно число не является квадратом другого");