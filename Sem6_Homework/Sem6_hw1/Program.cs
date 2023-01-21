// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

using static System.Console;
Clear();

WriteLine("count positive numbers ");
WriteLine("Input several numbers(even text allowed if need), separated by space. Press enter after finished");
bool ignory = true;  // if text is prophibited change ingnore to false!  (bool ignory = false;)
string[] InputArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//!!!!!!!!!!! if need input exactly M numbers(as in task above): comment 1 string above, uncomment block below!!!!!!

/* 
Write("Input how much numbers are to input (m)");
if (!int.TryParse(ReadLine(), out int m))
{
    WriteLine("M Must be Positive int value!");
    Environment.Exit(0);
}
if (m<=0)
{
    WriteLine("M Must be Positive int value!");
    Environment.Exit(0);
}
string[] InputArray = new string[m];
for (int i=0; i< m; i++)
{
    Write($"input {i+1} number: ");
    InputArray[i] = ReadLine();
}
*/ 

WriteLine($"Number of positive elements is: {CountPositives(InputArray, ignory)}");  // if add argument to CountPositives "ignore:false" - exit progr if char elements found (default true)

///////////////////// methods below ///////////////////

// count positive numbers in array
// if ignore = true - count even if char elements found
// if ignore = false - stop counting, exit programm
int CountPositives(string[] InArr, bool ignore = true)
{
    //double[] ArrayDouble = new double[InArr.Length];
    double temp = 0;
    int count = 0;
    for (int i = 0; i < InArr.Length; i++)
    {
        if (!double.TryParse((InArr[i]), out temp) & !ignore)
        {
            WriteLine("Not int or double found (char). Cant work farther. Now exit at all!!!");
            Environment.Exit(0);
        }
        else
        {
            count += temp > 0 ? 1 : 0;
        }
    }

    double[] ArrayDoubel = new double[InArr.Length];
    return count;
}