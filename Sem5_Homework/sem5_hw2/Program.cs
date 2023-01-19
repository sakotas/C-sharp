// Задача 36: Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

int[] GeneratedArray = GenerateRandArray(10, 0, 10);
PrintArray(GeneratedArray);
// odd - nechet
WriteLine($" summ of odd elements(index 1 , 3, 5 ....)= {CountOddEvenElements(GeneratedArray)}");
WriteLine($" summ of even elements(index 0, 2 , 4 ....)= {CountOddEvenElements(GeneratedArray, false)}");

///////////////////////////////////all  methods below//////////////////////////////////

// True - count summ of odd elements(indexes)
// False - count summ of Even elements(indexes)
int CountOddEvenElements(int[] InArray, bool Even = true)
{
    int Summ = 0;
    for (int i = Even ? 1 : 0; i < InArray.Length; i += 2)
    {
        Summ += InArray[i];
    }
    return Summ;
}

// Generate array of size = size, filled with random int numbers from BeginRand to EndRandint[] GenerateRandArray(int size, int BeginRand=0,int EndRand=100)
int[] GenerateRandArray(uint size, int BeginRand = 0, int EndRand = 9)
{
    if (size == 0)
    {
        WriteLine("Size can't be zero. Now terminate all progr");
        Environment.Exit(0);
    }

    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(BeginRand, EndRand + 1);
    }
    return result;
}

// Print given array to Console
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

