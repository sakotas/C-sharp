// **Задача 65:** Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;
Clear();

string result = GetNumbers(10, 20);
WriteLine(result);
WriteLine();
PrintNumbers(10, 20);

string GetNumbers(int m, int n)
{
    return n == m || m == n? n.ToString() : $"{GetNumbers(m, n - 1)}, {n}";
}

void PrintNumbers(int m, int n)
{
    if (n == m || m == n) Write(n);
    else
    {
        PrintNumbers(m, n -1);
        Write($", {n}");
    }
}