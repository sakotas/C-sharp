// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;
using MyLibArray;
Clear();

WriteLine("Input 6 parameters:");
WriteLine("Size of desired array. M, N - int Values");
WriteLine("Begin and end Values for random generate array(int or double Values))");
WriteLine("index x, index y of element which we want to check for it's value: ");
WriteLine();

string[] parametersString = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

if (parametersString.Length > 6)
{
    WriteLine("Warning! 6 parameters required. Al other will be casted aside!");
}
if ((parametersString.Length < 6))
{
    WriteLine("Error. Exactly 6 parameters required! Now Exit");
    Environment.Exit(0);
}


int sizeM = CheckInput(parametersString[0], "Only Int allowed");
int sizeN = CheckInput(parametersString[1], "Only Int allowed");
int indexX = CheckInput(parametersString[4], "Only Int allowed");
int indexY = CheckInput(parametersString[5], "Only Int allowed");
if (sizeM <= 0 || sizeN <= 0)
{
    WriteLine("Error! Array size must be above zero! Terminate progr!");
    Environment.Exit(0);
}
if (indexX < 0 || indexY < 0)
{
    WriteLine("Error! Index in array can't be negative! Terminate progr!");
    Environment.Exit(0);
}

if (indexX >= sizeM || indexY >= sizeN)
{
    WriteLine($"There is not index[{indexX},{indexY}] in array of size [{sizeM},{sizeN}] - out of range");
    Environment.Exit(1);
}

if ((int.TryParse(parametersString[2], out int BeginRandInt)) && (int.TryParse(parametersString[3], out int EndRandInt)))  // Generate int filled Array
{
    //int BeginRand = CheckInput(parametersString[2], "Only Int or double values allowed");
    //int EndRand = CheckInput(parametersString[3], "Only Int or double values allowed");
    int[,] array = MyLibArray.IntMultiDimentionalArray.GenerateIntMNArray(Convert.ToUInt32(sizeM), Convert.ToUInt32(sizeN), BeginRandInt, EndRandInt);
    MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array);
    WriteLine($"element{indexX}{indexY} = {array[indexX,indexY]}");

}
else if ((double.TryParse(parametersString[2], out double BeginRand)) && (double.TryParse(parametersString[3], out double EndRand)))  // Generate double filled Array
{   
double[,] array = MyLibArray.MultidimensionalArray.GenerateDoubleMNArray(Convert.ToUInt32(sizeM), Convert.ToUInt32(sizeN), BeginRand, EndRand);
    MyLibArray.MultidimensionalArray.PrintDoubleMNArray(array);
    WriteLine($"element[{indexX},{indexY}] = {array[indexX,indexY]}");

}
else
{
    WriteLine("Only Int or double values allowed for begin and end range of array");
    Environment.Exit(0);
}


//////////// All Methods below yhis line//////////////////////


int CheckInput(string inString, string errorMsg)
{
    if (!int.TryParse(inString, out int result))
    {
        WriteLine($"{inString} -> (int):  {errorMsg}. Now exit!");
        Environment.Exit(0);
    }
    return result;
}