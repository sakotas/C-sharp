using static System.Console;
Clear();

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Write("Input number: ");
int number = int.Parse(ReadLine()!);

// WriteLine($"Sum number 1..A = {GetSum(number)}");

WriteLine($"{number} -> {GetNumberOfDigits(number)}");

int GetNumberOfDigits(int n)
{
    int result = 1;
    int div = 10;
    while (n%div != n)
    {
        result++;
        div = div * 10;
    }

    return result;
}