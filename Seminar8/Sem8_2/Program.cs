// **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа 
//должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using static System.Console;
Clear();

int[,] array = MyLibArray.IntMultiDimentionalArray.GenerateIntMNArray(4, 4, 0, 10);
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array);

if (array.GetLength(0) != array.GetLength(1))
{
    WriteLine("Can't  =) ");
}
else
{
    int[,] newArray = RotateArray(array);
    WriteLine();
    MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(newArray);
}






////////////// methods below ///////////

int[,] RotateArray(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[j, i] = inArray[i, j];
        }
    }


    return result;
}