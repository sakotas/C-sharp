// Задача 34: Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

int[] GeneratedArray = GetIntNumDigArr(size: 8, NumLength: 3, Positive: true);

PrintArray(GeneratedArray);

WriteLine($"Number of even elements: {CountEvensOdds(GeneratedArray)}");
WriteLine($"Number of Odd elements: {CountEvensOdds(GeneratedArray, Even: false)}");
/////////////////////////////////// methods below//////////////////////////////////

// Count Even and odd elements of given array
int CountEvensOdds(int[] InArr, bool Even = true)
{
    int result = 0;
    if (Even)
    {
        foreach (int element in InArr)
        {
            result += element % 2 == 0 ? 1 : 0;
        }
    }
    else
    {
        foreach (int element in InArr)
        {
            result += Math.Abs(element % 2) == 1 ? 1 : 0;
        }
    }
    return result;
}


// generate certain size array filled with certain dig-lenth(default 1) int numbers, positive(default) or negative 
//int zize: size of array
//int NumLength: number of digits (ex NumLength 3: generate numbers from 100 to 999). Not compulsory argument - have default value "1"
//bool postive: true - generate only positive numbers. false - generate both. Not compulsory argument - have default value of true
int[] GetIntNumDigArr(uint size, uint NumLength = 1, bool Positive = true)
{
    if (size <= 0 || NumLength < 1)   // check for incorrect input and exit even from main! (because can't work further)
    {
        WriteLine("incorrect input args for method GetIntNumDigArr! size must be >0, NumLength > 0. Now Exit and close MAIN prog!!!");
        Environment.Exit(0);
    }

    int[] result = new int[size];
    Random rnd = new Random();
    int BeginRand = Convert.ToInt32(Math.Pow(10, Convert.ToDouble(NumLength - 1)));
    int EndRand = Convert.ToInt32(Math.Pow(10, Convert.ToDouble(NumLength)) - 1);
    for (int i = 0; i < size; i++)
    {
        if (!Positive && rnd.Next(0, 2) == 1)
        {
            result[i] = -1 * rnd.Next(BeginRand, EndRand);
        }
        else
        {
            result[i] = rnd.Next(BeginRand, EndRand);
        }
    }

    return result;
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