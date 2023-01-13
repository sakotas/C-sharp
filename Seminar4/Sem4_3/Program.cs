// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120


using static System.Console;
Clear();

Write("Input number:");
int n = int.Parse(ReadLine()!);

WriteLine($"product  1...n  = {GetMult(n)}");


int GetMult(int A)
{
    if (A <= 0) return 0;

    int result = 1;
    while (A>0)
    {
        result *= A;
        A--;
     
    }
    return result;
}

