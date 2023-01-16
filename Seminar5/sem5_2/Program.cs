using static System.Console;
Clear();

// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array1 = { -4, -8, 8, 2 };

PrintArray(array1);
WriteLine();
PrintArray(ChangeArray(array1));

int[] ChangeArray(int[] Array)
{
    int[] result = new int[Array.Length];
    for(int i = 0; i < Array.Length; i++)
    {
        result[i] = Array[i] * -1;
    }
    return result;

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