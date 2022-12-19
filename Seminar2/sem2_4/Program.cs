/*2 числа с клавиатуры.
Вывести в ответе только знак
5 и 7   < 
5 и 8   >
8 и 8   =
*/

using static System.Console;

Write("Input first number: ");
int FirstNumber = int.Parse(ReadLine()!);
Write("Input second number: ");
int SecondNumber = int.Parse(ReadLine()!);

if (FirstNumber > SecondNumber)
{
    WriteLine(">");
}
else if (FirstNumber < SecondNumber)
{
    WriteLine("<");
}
else
{
    WriteLine("=");
}

WriteLine("Пробуем через тернарную операцию из 3");


WriteLine(FirstNumber < SecondNumber ? "<" : FirstNumber > SecondNumber ? ">" : "=");
