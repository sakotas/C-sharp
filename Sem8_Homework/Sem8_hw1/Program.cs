// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] copyArray = MyLibArray.IntMultiDimentionalArray.CopyMNArray(array);

MyLibArray.IntMultiDimentionalArray.RegulaRizeArrayRowX(array, -1, false);  // -1 if we want regularize all rows. or write any number of row - for one row
WriteLine("all rows was regularized by decreasing(changing given array (main task was completed!)");
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array);
WriteLine();

MyLibArray.IntMultiDimentionalArray.RegulaRizeArrayColX(copyArray, -1, false);
WriteLine("all cols was regularized by decreasing(using copy of first randomly Generated array) - just an optional task");
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(copyArray);
WriteLine();


///// All Methods below ////


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
