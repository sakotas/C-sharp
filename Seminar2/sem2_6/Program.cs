/*
**Задача 16:**

Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/

using static System.Console;

Write("Input first number: ");
int FirstNumber = int.Parse(ReadLine()!);
Write("Input second number: ");
int SecondNumber = int.Parse(ReadLine()!);

if (FirstNumber * FirstNumber == SecondNumber) 
{
    WriteLine("Второе число является квадратом первого");
}
    else if (SecondNumber * SecondNumber == FirstNumber)
    {
        WriteLine("Первое число явялется квадратом второго");
    }
else
{
    WriteLine("NO!");
}

//Через тернарную операцию
WriteLine(
    FirstNumber*FirstNumber == SecondNumber ?
 "Второе число является квадратом первого" : SecondNumber * SecondNumber == FirstNumber ?
  "Первое число явялется квадратом второго": "NO!");
  