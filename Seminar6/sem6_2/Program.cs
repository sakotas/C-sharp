// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

using static System.Console;
Clear();

if (IsTriangle(2, 2, 3))
{
    WriteLine("Triangle exist");
}
else WriteLine("Triangle doesn't exist");

bool IsTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    else 
    {
        return false;
    }
}