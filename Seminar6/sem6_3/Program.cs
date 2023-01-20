// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

using static System.Console;
Clear();

int Dec = 15;  // number to convet

WriteLine($"dec {Dec} to bin = {DecToBin(Dec)}");
WriteLine($"dec {Dec} to bin(Convert method) = {Convert.ToString(Dec, 2)}");

WriteLine($"dec {Dec} to oct = {DecToBin(Dec, 8)}");
WriteLine($"dec {Dec} to oct(Convert method) = {Convert.ToString(Dec, 8)}");

// WriteLine($"dec {Dec} to hex = {DecToBin(Dec, !!!! )}"); // doesn't work because wasn't supposed to
WriteLine($"dec {Dec} to hex(Convert method) = {Convert.ToString(Dec, 16)}");




// string result = Convert.ToString(13/2);
// WriteLine($"test = {result}");
// WriteLine($"test = {(13/2)*2}");

string DecToBin(int number, int SystBase = 2)  // work with SystBase below 10
{
    string result = string.Empty;

    //if (number = 0) return 0;
    while (number > 0)
    {

        result = number % SystBase + result;
        number /= SystBase;
    }


    return result;
}