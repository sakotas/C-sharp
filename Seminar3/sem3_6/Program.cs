// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

using static System.Console;
Clear();

Write("Введите число N:");
bool isParse = int.TryParse(ReadLine(), out int n);

if (!isParse)
{
    WriteLine($"Братан, нужно число! А это - чушь собачья");
    return;
}

int i = 0;

while (i <= n)
{
    WriteLine($"{i} * {i} = {i*i}");
    i++;
}