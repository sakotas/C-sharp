// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

WriteLine("Find interseption of functions: y = k1 * x + b1, y = k2 * x + b2");

double b1 = CheckInput("Input b1: ");
double k1 = CheckInput("Input k1: ");
double b2 = CheckInput("Input b2: ");
double k2 = CheckInput("Input k2: ");

if (k1 == k2 && b1 == b2)
{
    WriteLine("Infinitive number of solutions: lines are equal");
}
else if (k1 == k2)
{
    WriteLine("No solutions: Lines ara parallel ");
}
else
{
    double x = (b2-b1) / (k1 - k2);
    double y = (k1 * (b2-b1))/ (k1-k2) + b1;
    WriteLine($"There is one solution(interseption): x={x}, y={y}");
}


double CheckInput(string message)
{
    Write(message);
    if (!double.TryParse(ReadLine(), out double result))
    {
        WriteLine("Only int and double values are allowed. Now terminate programm");
        Environment.Exit(0);
    }

    return result;

}