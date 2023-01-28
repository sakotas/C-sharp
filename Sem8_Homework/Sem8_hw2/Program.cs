// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
using MyLibArray;
Clear();


WriteLine("Input4 params separated by space: ");
WriteLine("- size of generated int array [M,N]");
Write("-Begin and End Values for Random for random Generate: ");
string[] paramStr = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

if (paramStr.Length != 4)
{
    WriteLine("you must input exactly 4 parameters. Not Less not more. Restart programm!");
    Environment.Exit(0);
}

uint sizeM = Convert.ToUInt32(CheckInput(paramStr[0], "Error! Please input only unsigned int for size M! Now Exit!", true)); //if true - need check for unsigned
uint sizeN = Convert.ToUInt32(CheckInput(paramStr[1], "Error! Please input only unsigned int for size N! Now Exit!", true));
int beginArr = CheckInput(paramStr[2], "Error! Please input only int numbers(for Random generate)!. Restart programm!", false); // if false - negative is allowed
int endArr = CheckInput(paramStr[3], "Error! Please input only int numbers(for Random generate)!. Restart programm!", false);

int[,] array = MyLibArray.IntMultiDimentionalArray.GenerateIntMNArray(sizeM, sizeN, beginArr, endArr);
WriteLine($"Randomly Generated int[{sizeM},{sizeN}] array below");
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array);

WriteLine($"row with minimum summ of elements(first meet) is {CheckMinSumRow(array)} - (!count from 1, not 0)");
WriteLine();


///// All Methods below ////
int CheckMinSumRow(int[,] inArray)
{
    int minSum = 0;
    int minSumIndex = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        minSum += inArray[0, j];
    }
    // WriteLine($"1 sum = {minSum} {minSum}");   // -- debug (didn't del for convinient of cod-reviewer)

    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumIndex = i;
        }
        // WriteLine($"{i+1} sum = {sum} (minSum = {minSum})"); // -- debug (didn't del for convinient of cod-reviewer)
    }
    return minSumIndex +1;
}

int CheckInput(string inArray, string errorMsg, bool unsigned)
{
    if (!int.TryParse(inArray, out int result))
    {
        WriteLine(errorMsg);
        Environment.Exit(0);
    }
    if (unsigned && result < 0)
    {
        WriteLine(errorMsg);
        Environment.Exit(0);
    }
    return result;
}

