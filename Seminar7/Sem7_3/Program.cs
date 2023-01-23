// **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// кроме нулевого индекса!

// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2

// 5 **81** 2 **9**

// 8 4 2 4

using static System.Console;
Clear();

Write("Input size of matrix and min max values separated by space: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));

PrintMatrixArrray (array);
EvenElementsPow2(array);
WriteLine("");
WriteLine("");
PrintMatrixArrray (array);

void EvenElementsPow2(int[,] inArray)
{
    for(int i=2; i< inArray.GetLength(0); i +=2)   
    {
     for(int j=2; j< inArray.GetLength(1); j +=2)
     {
        inArray[i,j] *= inArray[i,j];
     }      
    }
}

int [,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultArray = new int [rows, columns];
    Random rnd = new Random();
    for(int i =0; i < rows; i++)
    {
        for(int j =0; j < columns; j++)
        {
            resultArray[i,j] = rnd.Next(minValue, maxValue+1);
        }
    }
return resultArray;
}



void PrintMatrixArrray (int[,] inArray)
{
    for(int i =0; i < inArray.GetLength(0); i++)
    {
        for(int j =0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],5 }");  // фиксированный размер вывода
        }
    WriteLine();
    }
}




