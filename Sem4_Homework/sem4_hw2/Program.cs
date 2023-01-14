// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using static System.Console;
Clear();

WriteLine("Sum of all digits ");

Write("input any integer number: ");
if (!int.TryParse(ReadLine(), out int TheNumber))
{
    WriteLine("Error! Input int number, not string or float ");
    return -1;
}

WriteLine($"sum of digits of the number {TheNumber} is {SumOfDigits(TheNumber)}");
return 1;

int SumOfDigits(int number)
{
    int result = 0;
    number = Math.Abs(number);
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    
    return result;
}
