// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5

using static System.Console;
Clear();

Write("Input number:");
int number = int.Parse(ReadLine()!);

WriteLine(CountDigit(number));


int CountDigit(int numb)
{
    int result = 0;

    while ( Math.Abs(numb) > 0)
    {   
        numb /= 10;
        result ++;
    }
    return result;
}