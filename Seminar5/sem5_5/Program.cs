﻿using static System.Console;
Clear();

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

Write("Введите размер массива, мин и макс через пробел: ");
string[] parametersArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parametersArray[0]), int.Parse(parametersArray[1]), int.Parse(parametersArray[2]));
WriteLine("=====Готов Массив=====");
PrintArray(array);
WriteLine();
WriteLine("======================");
WriteLine();

WriteLine($"Преобразованный массив: ");
PrintArray(MultiArray(array));


int[] MultiArray(int[] inArray)
{
    int size = inArray.Length / 2;
    if (inArray.Length % 2 != 0) size++;
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[inArray.Length - i - 1];
    }

    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;

}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}


// Clear();
// Write("Ведите кор А через пробел: ");
// Point A = GetPointFromString(ReadLine()!);
// Write("Ведите кор B через пробел: ");
// Point B = GetPointFromString(ReadLine()!);

// double delta = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2) + Math.Pow(A.Z - B.Z, 2));
// WriteLine(delta);



// Point GetPointFromString(string inStr)
// {
//     Point res = new Point();
//     string[] par = inStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     res.X = int.Parse(par[0]);
//     res.Y = int.Parse(par[1]);
//     res.Z = int.Parse(par[2]);
//     return res;
// }


// struct Point
// {
//     public int X;
//     public int Y;
//     public int Z;
// }

// struct MyStruct
// {
//     public int ArrayValue;
//     public int ArrayIndex;
// }