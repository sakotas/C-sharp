using static System.Console;
Clear();

// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

int[] array = { 1, 2, 3, 4, 5, 6, 7 };
PrintArray(array);
int[] newArray = CopyArray(array);
PrintArray(newArray);

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}

int[] CopyArray(int[] inArray)
{
    int[] newArray = new int[inArray.Length];


    for (int i = 0; i < inArray.Length; i++)
    {
        newArray[i] = inArray[i];
    }
    WriteLine();
    WriteLine("Массив скопирован!");
    return newArray;
}