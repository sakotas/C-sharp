// Вывести квадраты чисел от 1 до N


using static System.Console;
Clear();

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
        Write($"{Math.Pow(index, 2)} ");
        index += 1;
    }
    WriteLine(" ");
}
else
{
    int index = 1;
    while (index >= N)
    {
        Write($"{Math.Pow(index, 2)} ");
        index -= 1;
    }
    WriteLine(" ");
}
