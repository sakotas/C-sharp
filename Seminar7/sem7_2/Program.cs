using static System.Console;
Clear();

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

WriteLine("Введите размер матрицы m и n значения через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine($"Значение m: {int.Parse(parameters[0])}");
WriteLine($"Значение n: {int.Parse(parameters[1])}");

int[,] array = GetMatrixArray();
PrintMatrixArray(array);

int[,] GetMatrixArray()
{
    int m = int.Parse(parameters[0]);
    int n = int.Parse(parameters[1]);
    
    int[,] resultArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = i + j;
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
            Write($"{inArray[i, j], 2} ");
        }
        WriteLine();
    }
}

