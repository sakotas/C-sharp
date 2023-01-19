// Задача 38: Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.

// [3,3 7,1 22,5 2,2 78,2] -> 76
using static System.Console;
Clear();

double[] GeneratedArray = GenerateDoubleArray(8);
//double[] GeneratedArray = GenerateDoubleArray(8, 1, 9);

PrintDoubleArray(GeneratedArray, 2);
//PrintDoubleArray(GeneratedArray);

WriteLine($"diffr between max and min elements = {MinMaxDifr(GeneratedArray, 2)}");
//WriteLine($"diffr between max and min elements = {MinMaxDifr(GeneratedArray)}");



///////////////////////////////////all  methods below//////////////////////////////////

// returns difr between max and min elements of array. In case of need can round result by using arg "round" (default 4)
double MinMaxDifr(double[] InnArr, uint round = 4)
{
    double max = InnArr[0];
    double min = InnArr[0];

    for (int i = 0; i < InnArr.Length; i++)
    {
        max = InnArr[i] > max ? InnArr[i] : max;
        min = InnArr[i] < min ? InnArr[i] : min;
    }

    return Math.Round(max - min, Convert.ToInt32(round));
}


// generate random array of certain size, filled with double type values from BeginArr(default=0) to EndArr(defaullt=10)
double[] GenerateDoubleArray(uint size, double BeginArr = 0, double EndArr = 10)
{
    if (size == 0)
    {
        WriteLine("Size can't be zero. Now terminate all progr");
        Environment.Exit(0);
    }

    double[] result = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = BeginArr + rnd.NextDouble() * (EndArr - BeginArr);
    }
    return result;
}

// print double valuses-array  to console. 
void PrintDoubleArray(double[] arr, uint round = 4)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{Math.Round(arr[i], Convert.ToInt32(round))}, ");
    }
    Write($"{Math.Round(arr[arr.Length - 1], Convert.ToInt32(round))}]");
    WriteLine();
}
