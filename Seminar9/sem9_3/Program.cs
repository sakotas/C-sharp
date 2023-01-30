// **Задача 67:** Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

using static System.Console;
Clear();

WriteLine(SumNumber(123456789));

int SumNumber(int num)
{
    if (num == 0) return 0;
    else
    {
        return SumNumber(num / 10) + num % 10;
    }
}