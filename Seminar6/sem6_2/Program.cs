using static System.Console;
Clear();

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

Write("Введите размер трех сторон треугольника через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int sideA = int.Parse(parameters[0]);
int sideB = int.Parse(parameters[1]);
int sideC = int.Parse(parameters[2]);

CheckTriangle(sideA, sideB, sideC);

void CheckTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) WriteLine("Треугольник существует");
    else WriteLine("Треугольник не существует");

}