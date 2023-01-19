using static System.Console;
Clear();

// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Write("Введите число: ");
int n = int.Parse(ReadLine()!);

// WriteLine();
// WriteLine(n);
WriteLine(MakeBinary(n));

string MakeBinary(int number)
{
    string result = "";
    int rem;

    while (number > 0)
    {

        rem = number % 2;
        number /= 2;
        result = rem.ToString() + result;
    }
    return result;

}
