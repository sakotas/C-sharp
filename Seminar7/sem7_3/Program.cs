using static System.Console;
Clear();

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 *81* 2 *9*
// 8 4 2 4

WriteLine("Введите размер матрицы m и n значения через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine($"Значение m: {int.Parse(parameters[0])}");
WriteLine($"Значение n: {int.Parse(parameters[1])}");
WriteLine();
int[,] array = GetMatrixArray();
PrintMatrixArray(array);
WriteLine();
PowerEvenIndexes(array);
PrintMatrixArray(array);
WriteLine();
WriteLine("====UNIT TEST====");
int[,] testArray = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
PrintMatrixArray(testArray);
PowerEvenIndexes(testArray);
WriteLine();
PrintMatrixArray(testArray);


int[,] GetMatrixArray()
{
    Random rnd = new Random();
    int m = int.Parse(parameters[0]);
    int n = int.Parse(parameters[1]);

    int[,] resultArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i, j] = rnd.Next(2, 10);
        }

    }
    return resultArray;
}

void PowerEvenIndexes(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == 0 || j == 0) inArray[i, j] = inArray[i, j];
            else if (i % 2 == 0 && j % 2 == 0) inArray[i, j] = inArray[i, j] * inArray[i, j];
        }
    }
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