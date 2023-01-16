using static System.Console;
Clear();

// **Задача 33:** Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array1 = { 6, 7, 19, 345, 3, 3 };

PrintArray(array1);
WriteLine();
WriteLine(SearchElement(4, array1)?"Да":"Нет");
WriteLine(SearchElement(3, array1)?"Да":"Нет");

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}

bool SearchElement(int element, int[] array)
{
    foreach (int i in array)
    {
        if(element == i) return true;
    }
    return false;
}
