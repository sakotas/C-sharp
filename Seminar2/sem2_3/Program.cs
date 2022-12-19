/* **Задача 12:** 

Напишите программу, которая будет принимать на вход два 
числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу
 первому, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4  -> кратно

*/
using static System.Console;

WriteLine("Input first number");
int FirstNumber = int.Parse(ReadLine()!);
WriteLine("Input second number");
int SecondNumber = int.Parse(ReadLine()!);

if (FirstNumber % SecondNumber == 0)
{
    WriteLine("divisible");
}
else
{
    WriteLine($"Остаток от деления числа {FirstNumber} на число {SecondNumber} = {FirstNumber % SecondNumber}");
    WriteLine("Остаток от деления числа {0} на число {1} = {2}", FirstNumber, SecondNumber, FirstNumber % SecondNumber);
    WriteLine("Остаток от деления числа" + FirstNumber + " на число" + SecondNumber + " = " +  FirstNumber % SecondNumber);
}

WriteLine("Теперь пробуем  тернарную операцию");

//FirstNumber % SecondNumber == 0
WriteLine(FirstNumber % SecondNumber == 0 ? "divisible": "Остаток от деления числа {0} на число {1} = {2}", FirstNumber, SecondNumber, FirstNumber % SecondNumber);