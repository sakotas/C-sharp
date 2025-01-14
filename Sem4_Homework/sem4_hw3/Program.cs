﻿// Задача 29: Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

//////  метод, который сформирует массив указанного размера в диапазоне указанных чисел


using static System.Console;
Clear();

WriteLine("Random array size Z");

Write("input any integer number (array size): ");
if (!int.TryParse(ReadLine(), out int ArraySize))
{
    WriteLine("Error! Input int number, not string or float ");
    return -1;
}
if (ArraySize <=0)
{
    WriteLine("Array size can't be zero or below. Now exit");
    return -1;
}

Write("input lower range of Random: ");
if (!int.TryParse(ReadLine(), out int LowerRange))
{
    WriteLine("Error! Input int number, not string or float ");
    return -1;
}

Write("input upper range of Random: ");
if (!int.TryParse(ReadLine(), out int UpperRange))
{
    WriteLine("Error! Input int number, not string or float ");
    return -1;
}

PrintArray(GenerateArray(ArraySize, LowerRange, UpperRange));


return 1;

 int[] GenerateArray(int size, int begin, int end)
 {
    int[] array = new int[size];
    //array[i] = new Random().Next(0,2)
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(begin, end+1);
    }
    return array;
 }

void PrintArray(int[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        Write ($" {arr[i]}");
    }
    WriteLine();
}
