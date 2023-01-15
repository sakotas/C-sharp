using static System.Console;
Clear();

int[] ar = new int[8];

PrintArray(ar);
PrintArray(FillArrayRandom(ar));
PrintArray(FillArrayManual(ar));

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

int[] FillArrayRandom(int[] array)
{
    int[] result = new int[array.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = new Random().Next(1, 99);
    }

    return result;
}

int[] FillArrayManual(int[] array)
{
    int[] result = new int[array.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        Write($"Введите число в индекс массива [{i}]:");
        result[i] = int.Parse(ReadLine()!);
        WriteLine();
    }

    return result;
}