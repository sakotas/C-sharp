// сумма чисел от 1 до N на которые делится N без остатка

using static System.Console;
Clear();

Write("Input number:");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);
WriteLine ($"Sum 1...A = {sum}");

int GetSum(int A)
{
    int result = 0;
    int i = 1;
    while (i<=Math.Abs(A))
    {
        if (A % i == 0) result += i;
        i ++;
     
    }
    if (A < 1) result *= -1;
    return result;
}