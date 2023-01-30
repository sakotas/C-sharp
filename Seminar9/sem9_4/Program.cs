﻿// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Функция Кермана

using static System.Console;
Clear();


WriteLine(PowNumber(2, 3));

int PowNumber(int a, int b)
{
    if (b == 1) return a;
    else
    {
        return PowNumber(a, b-1) * a;
    }
}



