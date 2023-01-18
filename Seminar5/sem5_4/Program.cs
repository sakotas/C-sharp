// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

using static System.Console;
Clear();

int[] GeneratedArray = GenerateArray(10, 0, 11);
PrintArray(GeneratedArray);

WriteLine($"Num of elements between 10 and 99 is {FindColElements(GeneratedArray,10 , 99)} ");


int FindColElements(int[] InArray, int MinElement, int MaxElement)
{
    int sum_col = 0;
    foreach (var element in InArray)
    { 
        
        if (( element >= MinElement) && (element <= MaxElement))  
        {
            sum_col += 1;
        }
    }
    return sum_col;
}

 int[] GenerateArray(int size, int begin, int end)
 {
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(begin, end+1);
    }
    return array;
 }

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[arr.Length - 1]}]");
    WriteLine();
}