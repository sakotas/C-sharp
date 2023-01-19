using static System.Console;
Clear();

// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Write("Введите число: ");
int n = int.Parse(ReadLine()!);

Fibonacci(n);

void Fibonacci(int number)
{
    if (number == 1 || number == 2) WriteLine("1");
    else
    {
        int temp, num1 = 0, num2 = 1;
        Write($"{num1} {num2}");
        for (int i = 2; i < number; i++)
        {
            temp = num1 + num2;
            num1 = num2;
            num2 = temp;
            Write($" {num2}");
        }
    }
}