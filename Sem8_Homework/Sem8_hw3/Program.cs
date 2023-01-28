// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
using MyLibArray;
Clear();


WriteLine("Input5 params separated by space: ");
WriteLine("- size of generated first int array [M,N]");
WriteLine("- size of generated second int array [N,K]");
Write("-Begin and End Values for Random for random Generate: ");
string[] paramStr = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

if (paramStr.Length != 5)
{
    WriteLine("you must input exactly 5 parameters. Not Less not more. Restart programm!");
    Environment.Exit(0);
}

uint sizeM = Convert.ToUInt32(CheckInput(paramStr[0], "Error! Please input only unsigned int for size M! Now Exit!", true)); //if true - need check for unsigned
uint sizeN = Convert.ToUInt32(CheckInput(paramStr[1], "Error! Please input only unsigned int for size N! Now Exit!", true));
uint sizeK = Convert.ToUInt32(CheckInput(paramStr[2], "Error! Please input only unsigned int for size K! Now Exit!", true));
int beginArr = CheckInput(paramStr[3], "Error! Please input only int numbers(for Random generate)!. Restart programm!", false); // if false - negative is allowed
int endArr = CheckInput(paramStr[4], "Error! Please input only int numbers(for Random generate)!. Restart programm!", false);


int[,] array1 = MyLibArray.IntMultiDimentionalArray.GenerateIntMNArray(sizeM, sizeN, beginArr, endArr);
WriteLine("First matrix int random generated:");
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array1);
WriteLine();

int[,] array2 = MyLibArray.IntMultiDimentionalArray.GenerateIntMNArray(sizeN, sizeK, beginArr, endArr);
WriteLine("Second matrix int random generated:");
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array2);
WriteLine();

int[,] resultArray = ProductMatrixMNK(array1, array2);
WriteLine("Result of product matrixs below:");
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(resultArray);


///// all methods below /////////////

int[,] ProductMatrixMNK(int[,] inArray1, int[,] inArray2)
{
    int[,] result = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            for (int k = 0; k < inArray1.GetLength(1); k++)
            {
                result[i, j] += inArray1[i,k]*inArray2[k,j];
            }
        }
    }
    return result;
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
