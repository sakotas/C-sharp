// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/* нет ограничения на N поэтому рассматриваем и для N отрицательного*/

using static System.Console;
Clear();

WriteLine ("make numbers from 1 to N to the third power.");
Write("input N:");
if (!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Error. Input number, not string");
    return;
}
if (N > 0)
{
    int index = 1;
    while (index <= N)
    {
        Write($"{Math.Pow(index, 3)} ");
        index += 1;
    }
    WriteLine(" ");
}
else   
{
    int index = 1;
    while (index >= N)
    {
        Write($"{Math.Pow(index, 3)} ");
        index -= 1;
    }
    WriteLine(" ");
}
