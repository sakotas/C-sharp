// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

using static System.Console;
Clear();

int[] FirstArray = { 1, 2, 5, 6, 7 };
WriteLine($"coppied array = {string.Join(" ", CopyArr(FirstArray))}");


int[] CopyArr(int[] InnArr, int size = 5)
{
    int[] result = new int[InnArr.Length];
    for (int i= 0; i < InnArr.Length; i++)
    {
        result[i] = InnArr[i];
    }
    return result;
}
