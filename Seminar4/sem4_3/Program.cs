using static System.Console;
Clear();

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Write("Input number n: ");
int number = int.Parse(ReadLine()!);

WriteLine($"Product of number 1..n = {GetProduct(number)}");

int GetProduct(int n)
{
    int result = 1;
    while (n > 0)
    {
        result = result * n;
        n--;
    }
    return result;
}