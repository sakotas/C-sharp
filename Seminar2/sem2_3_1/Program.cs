using static System.Console;
Clear();
WriteLine("Input number 1: ");
int num1 = int.Parse(ReadLine()!);

WriteLine("Input number 2: ");
int num2 = int.Parse(ReadLine()!);

// if (num1 < num2)
// {
//     WriteLine("<");
// }
// else if (num1 > num2)
// {
//     WriteLine(">");
// }
// else
// {
//     WriteLine("=");
// }

WriteLine(num1<num2?"<":num1>num2?">":"=");