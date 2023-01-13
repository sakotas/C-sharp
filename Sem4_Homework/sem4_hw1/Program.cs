// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

using static System.Console;
Clear();

WriteLine("make number A to the B power (natural) (without using math library)");

Write("input any integer number A:");
if (!int.TryParse(ReadLine(), out int a))
{
    WriteLine("Error! Input number, not string or float");
    return -1;
}

Write("input Natural number B:");
if (!int.TryParse(ReadLine(), out int b))
{
    WriteLine("Error! Input number, not string or float");
    return -1;
}
if (b <= 0) 
{
    WriteLine("Only natural number allowed!");
    return -1;
}


WriteLine($"{a} to the power {b} = {PowAB(a,b)}");
return 1;


int PowAB (int a, int b)
{
    int result = 1;
    for (int i=1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}