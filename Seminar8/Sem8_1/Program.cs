// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4

// 5 9 2 3

// 1 4 7 2

using static System.Console;
Clear();

int[,] array = MyLibArray.IntMultiDimentionalArray.GenerateIntMNArray(3,4,0,10);
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array);


int[] tempArr = new int[array.GetLength(1)];

for(int i = 0; i < array.GetLength(1); i++)
{
    tempArr[i] = array[0,i];
    array[0,i] = array[array.GetLength(0)-1, i];
    array[array.GetLength(0)-1, i] = tempArr[i];

}
WriteLine();
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array);


