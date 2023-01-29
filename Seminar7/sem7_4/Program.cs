using static System.Console;
Clear();

// **Задача 51:** Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

WriteLine("Введите размер матрицы через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray();

WriteLine();
PrintMatrixArray(array);
WriteLine();
WriteLine(SumMainDiagonal(array));

int SumMainDiagonal(int[,] inArray)
{
    int result = 0;

    // for (int i = 0; i < inArray.GetLength(0); i++)
    // {
    //     for (int j = 0; j < inArray.GetLength(1); j++)
    //     {
    //         if(i == j) result += inArray[i,j];
    //     }
    // }

    for (int i = 0;
            i < (inArray.GetLength(0) < inArray.GetLength(1) ?
            inArray.GetLength(0) : inArray.GetLength(1));
            i++)
    {
        result += inArray[i, i];
    }
    return result;
}

int[,] GetMatrixArray()
{
    Random rnd = new Random();
    int m = intParams[0];
    int n = intParams[1];

    int[,] resultArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
        }

    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],2} ");
        }
        WriteLine();
    }
}

