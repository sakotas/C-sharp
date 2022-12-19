using static System.Console;
Clear();
WriteLine("Input number 1: ");
int num1 = int.Parse(ReadLine()!);

WriteLine("Input number 2: ");
int num2 = int.Parse(ReadLine()!);

WriteLine(num1<num2?"<":">");