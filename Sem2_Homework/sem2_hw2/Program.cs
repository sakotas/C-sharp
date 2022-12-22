// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6


using static System.Console;
Clear();

Write("Input the number(от -2147483648 до 2147483647): ");
int Number = int.Parse(ReadLine()!);

if (Math.Abs(Number) < 100)
{
    WriteLine("There is no third digit in the number: {0}", Number);
    return -1;  // in case of need  return "-1": mean no 3rd digit in the number.
}

int Digit3 = (Math.Abs(Number) - (Math.Abs(Number) / 1000) * 1000) / 100;
WriteLine("Third digit of the number {0} is: {1}", Number, Digit3);

return Digit3;  // in case of need we return the 3rd digit