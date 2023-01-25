// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12


using static System.Console;
Clear();
Write("Input size of matrix and min max values separated by space");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));

PrintMatrixArrray(array);

WriteLine($"summ main diag = {SummElementsMainDiag(array)}");

int SummElementsMainDiag(int[,] inArray)
{
    int summ = 0;
    int min = inArray.GetLength(0);
    if (inArray.GetLength(0) > inArray.GetLength(1))
    {
        min = inArray.GetLength(1);
    }
    for (int i = 0; i < min; i++)
    {
        summ += inArray[i, i];
    }
    return summ;
}

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultArray = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArrray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5}");  // фиксированный размер вывода
        }
        WriteLine();
    }
}

