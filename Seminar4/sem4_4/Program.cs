using static System.Console;
Clear();

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr = new int[8];

PrintArray(InitFillArrayRandom());

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

int[] InitFillArrayRandom()
{
    int[] result = new int[8];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 2);
    }

    return result;
}