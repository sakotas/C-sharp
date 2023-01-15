using static System.Console;

Clear();
Write("Input number: ");
int number = int.Parse(ReadLine()!);

WriteLine($"Sum number 1..A = {GetSum(number)}");

int GetSum(int A)
{
    int result = 0;
    while (A > 0)
    {
        result = result + A;
        A--;
    }
    return result;
}