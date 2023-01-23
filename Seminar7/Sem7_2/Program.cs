// **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5
using static System.Console;
Clear();
Write("Input size of array (m,n) ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetNewArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
Print2dArray(array);

int[,] GetNewArray(int m, int n)
{
    int[,] resultArray = new int[m,n];
    for(int i = 0; i< m; i++)
    {
        for(int j=0; j< n; j++)
        {
            resultArray[i,j] = i+j;
        }
    
    }
    return resultArray;
}

void Print2dArray(int[,] inArray)
{
     for(int i = 0; i< inArray.GetLength(0); i++)
    {
        for(int j=0; j< inArray.GetLength(0); j++)
        {
            Write($" {inArray[i,j]}" );
        }
    WriteLine("");
    }
   
}